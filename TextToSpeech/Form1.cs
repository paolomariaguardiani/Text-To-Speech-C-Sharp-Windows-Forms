using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;

/* 
 * Autore: Paolo Maria Guardiani
 * 
 * DEO GRATIAS!
 * 
 * Per la parte relativa alla sintesi vocale va ringraziato: https://www.youtube.com/watch?v=RSoTS4aysig
 * Invece per la parte relativa alla gestione delle finestre e di tutto il resto
 * va ringraziato l'autore di questo tutorial: https://youtu.be/zfz49gjnjcY?t=2098 
 * 
 */


// Guardare questo sito della Microsoft per le informazioni sulla sintesi vocale:
// https://docs.microsoft.com/en-us/archive/msdn-magazine/2019/june/speech-text-to-speech-synthesis-in-net

// Guardare questo esempio per mettere in pausa e stoppare il tutto:
// https://github.com/evilprince2009/Slang.NET/blob/main/Slang.NET/AppForm.cs

// Grande tutorial (utilizzo di sliders e registrazione di un file audio): https://youtu.be/-jBARiOEaI8

// Altro tutorial utile: https://youtu.be/9xeIEcr7lqs

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        string testo;
        int volume;
        int speed;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        private SoundPlayer elevator, soundClick, handBell, soundError;

        public Form1()  // questo è il constructor
        {
            InitializeComponent();
            // Il testo scritto deve essere tutto maiuscolo
            // thanks to: https://stackoverflow.com/questions/10104515/how-to-convert-string-to-uppercase-in-windows-textbox
            testoDaAscoltare.CharacterCasing = CharacterCasing.Upper;
            
            // Aggiungo al menu a tendina le voci installate in Windows
            //// Thanks to: https://youtu.be/e8HiuJbK6ZI
            foreach (var voice in synth.GetInstalledVoices())
            {
                comboBoxVoci.Items.Add(voice.VoiceInfo.Name);
            }
            // Inserisco un valore di default nel combobox
            // altrimenti se faccio partire la lettura senza aver selezionato nulla mi dà un errore
            comboBoxVoci.SelectedIndex = 0;

            // we construct the object
            elevator = new SoundPlayer("sounds/elevator_bell.wav");
            soundClick = new SoundPlayer("sounds/button_click_soft.wav");
            handBell = new SoundPlayer("sounds/hand_bell_b_single.wav");
            soundError = new SoundPlayer("sounds/windows_error.wav");
        }

        //private void Form1_load(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        // questa parte del programma serve per far leggere il testo dal computer
        private void button1_Click_1(object sender, EventArgs e)
        {
            soundClick.Play();
            // Questa riga serve per leggere un nuovo testo se prima ne ho letto già uno
            synth.Dispose();

            // Adesso però ho eliminato un oggetto Speak e devo ricrearlo
            synth = new SpeechSynthesizer();
            testo = testoDaAscoltare.Text;
            string testoMaiuscolo = testo.ToUpper();
            testoDaAscoltare.Text = testoMaiuscolo;

            // La lettura avviene con la voce selezionata nel menu a tendina per la scelta della voce
            synth.SelectVoice(comboBoxVoci.Text);

            // Regolo il volume del testo parlato (valore minimo = 0; valore massimo = 100, default = 80)
            volume = trackBarVolume.Value;
            synth.Volume = volume;
            lblVolume.Text = $"VOLUME = {volume}";
            // Regolo la velocità del testo parlato (valore minimo = ; valore massimo = ; default = 
            speed = trackBarSpeed.Value;
            synth.Rate = speed;
            lblSpeed.Text = $"VELOCITA' = {speed}";


            // Comincio la lettura del testo
            // Importante: deve essere SpeakAsync e non Speak
            // In questo modo il programma può fare una pausa, continuare, cancellare il testo, ecc.
            synth.SpeakAsync(testo);
        }

       
        private void btnCancella_Click(object sender, EventArgs e)
        {
            soundClick.Play();
            // Cancello l'oggetto Speak (come se cliccassi su Stop)
            synth.Dispose();
            // Cancello il testo presente nella casella di testo multilinea
            testoDaAscoltare.Text = "";
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            soundClick.Play();
            //if (synth.State == SynthesizerState.Speaking)
            //{
            //    synth.Pause();
            //}
            // metti in pausa la lettura
            synth.Pause();
        }

        private void btnRiprendi_Click(object sender, EventArgs e)
        {
            soundClick.Play();
            // riprendi la lettura del testo
            synth.Resume();
        }

     
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            soundClick.Play();
            // Registrazione di un file .wav
            // Creo localmente un oggetto per lo SpeechSynthesizer
            // Thanks to: https://youtu.be/-jBARiOEaI8
            SpeechSynthesizer synth = new SpeechSynthesizer();
            SaveFileDialog sfd = new SaveFileDialog();

            // questo comando permette di salvare il file in base alla voce selezionata
            synth.SelectVoice(comboBoxVoci.Text);

            // Regolo il volume del testo parlato (valore minimo = 0; valore massimo = 100, default = 80)
            volume = trackBarVolume.Value;
            synth.Volume = volume;

            // Regolo la velocità del testo parlato (valore minimo = ; valore massimo = ; default = 

            speed = trackBarSpeed.Value;
            synth.Rate = speed;
            
            try
            {
                // creaiamo un filtro che abbia una estensione di default .wav
                sfd.Filter = "Wave Files| *.wav";
                sfd.ShowDialog();
                // settiamo l'output to wave file
                synth.SetOutputToWaveFile(sfd.FileName);
                // gestiamo il tutto in modo sincronizzato grazie alla riga seguente
                synth.Speak(testoDaAscoltare.Text);
                // risettiamo l'audio al default device
                synth.SetOutputToDefaultAudioDevice();

                handBell.Play();
                MessageBox.Show("Il file audio è stato registrato con successo.", "Text To Speech"); 
            }
            catch (Exception ex)
            {
                soundError.Play();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            soundClick.Play();
            // Esce dal programma
            Application.Exit(); 
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            elevator.Play();
            // Incollo il testo presente nella clipboard all'interno del textBox
            // thanks to: https://youtu.be/9Jxv-3DenmM
            testoDaAscoltare.Text = Clipboard.GetText();

        }
    }
} 