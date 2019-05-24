using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Tehnomanija
{
    public partial class Form1 : Form
    {
        public IWebDriver _driver;
        public string link = "https://birthday.thm.in.rs/#/panorama";
        public int pauza = 1000;
        public string pageSource;
        private List<Poklon> pokloni = new List<Poklon>();
        private List<int> noviPokloni = new List<int>();
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer("queen.wav");
        public Boolean automatskiKlik = true;
        public Form1()
        {
            InitializeComponent();
            try
            {
                btnPokreniChrome.Enabled = true;
                btnStart.Enabled = false;
                btnZaustavi.Enabled = false;
                timerRefresh.Interval = pauza * 2;
            }
            catch (Exception ex)
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                player.Stop();
                timerRefresh.Stop();
                MessageBox.Show("Naziv klase: " + this.GetType().Name + "\n Funkcija: " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\"" + ex.Message.ToString().Trim().Substring(0, Math.Min(ex.Message.ToString().Trim().Length, 350)) + "\"", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPokreniChrome_Click(object sender, EventArgs e)
        {
            try
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                _driver = new ChromeDriver();
                _driver.Navigate().GoToUrl(link);
            }
            catch (Exception ex)
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                player.Stop();
                timerRefresh.Stop();
                MessageBox.Show("Naziv klase: " + this.GetType().Name + "\n Funkcija: " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\"" + ex.Message.ToString().Trim().Substring(0, Math.Min(ex.Message.ToString().Trim().Length, 350)) + "\"", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //player.Play();
                //noviPokloni.Add(1);
                //timerJavaScript.Start();
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = false;
                btnZaustavi.Enabled = true;
                timerRefresh.Start();
            }
            catch (Exception ex)
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                player.Stop();
                timerRefresh.Stop();
                MessageBox.Show("Naziv klase: " + this.GetType().Name + "\n Funkcija: " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\"" + ex.Message.ToString().Trim().Substring(0, Math.Min(ex.Message.ToString().Trim().Length, 350)) + "\"", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            try
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                automatskiKlik = true;
                player.Stop();
                timerJavaScript.Stop();
                timerRefresh.Stop();
            }
            catch (Exception ex)
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                player.Stop();
                timerRefresh.Stop();
                MessageBox.Show("Naziv klase: " + this.GetType().Name + "\n Funkcija: " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\"" + ex.Message.ToString().Trim().Substring(0, Math.Min(ex.Message.ToString().Trim().Length, 350)) + "\"", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerRefresh(object sender, EventArgs e) //URADI SVAKIH 2 SEKUNDE
        {
            try
            {
                if (link.Trim().ToLower() == _driver.Url.Trim().ToLower()) //UKOLIKO JE LINK DOBAR
                {
                    _driver.Navigate().Refresh();
                    Thread.Sleep(pauza);
                    Console.WriteLine(_driver.PageSource);
                    ucitajInfo();
                }
            }
            catch (Exception ex)
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                player.Stop();
                timerRefresh.Stop();
                MessageBox.Show("Naziv klase: " + this.GetType().Name + "\n Funkcija: " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\"" + ex.Message.ToString().Trim().Substring(0, Math.Min(ex.Message.ToString().Trim().Length, 350)) + "\"", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TimerJavaScript(object sender, EventArgs e)
        {
            try
            {
                prikaziNovePoklone(noviPokloni);
            }
            catch (Exception ex)
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                player.Stop();
                timerRefresh.Stop();
                MessageBox.Show("Naziv klase: " + this.GetType().Name + "\n Funkcija: " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\"" + ex.Message.ToString().Trim().Substring(0, Math.Min(ex.Message.ToString().Trim().Length, 350)) + "\"", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void prikaziNovePoklone(List<int> lista)
        {
            try
            {
                int pomeri = 300;
                int br = 0;
                foreach (int pok in lista)
                {
                    IWebElement slika = _driver.FindElement(By.XPath("//*[@id='pano']/div[2]/div[2]/div/div[" + pok + "]/div/div/img"));
                    IWebElement element = _driver.FindElement(By.XPath("//*[@id='pano']/div[2]/div[2]/div/div[" + pok + "]"));

                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].style.height = '200px'; arguments[0].style.width = '200px'; arguments[0].style.visibility='visible';", slika);
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].style.visibility='visible'; arguments[0].setAttribute('style', 'transform: translateX(" + br++ * pomeri + "px) translateY(0px) translateZ(0px)')", element);

                    if (automatskiKlik == true)
                    {
                        Actions builder = new Actions(_driver);
                        builder.MoveToElement(slika).Click(slika);
                        builder.Perform();
                        automatskiKlik = false;
                    } 
                }
            }
            catch (Exception ex)
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                player.Stop();
                timerJavaScript.Stop();
                timerRefresh.Stop();
                MessageBox.Show("Naziv klase: " + this.GetType().Name + "\n Funkcija: " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\"" + ex.Message.ToString().Trim().Substring(0, Math.Min(ex.Message.ToString().Trim().Length, 350)) + "\"", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucitajInfo()
        {
            try
            {
                var lines = File.ReadAllLines("info.txt");
                var elementi = _driver.FindElements(By.XPath("//*[@id='pano']/div[2]/div[2]/div/div"));

                if (_driver.PageSource.Contains("ZUMIRAJ I POKLONE OTKRIVAJ!"))
                    timerRefresh.Interval = pauza * 2;
                else
                {
                    timerRefresh.Interval = pauza + 500;
                    return;
                }

                if (lines[0].Trim() != "0" && pokloni.Count == 0)  //UKOLIKO POSTOJI VEC NESTO UNUTRA URADICE OVO I LISTA JE PRAZNA
                {
                    foreach (string line in lines.Skip(1))
                    {
                        var splitString = line.Split('@');
                        Poklon p = new Poklon(Convert.ToInt32(splitString[0]), splitString[1], splitString[2]);
                        pokloni.Add(p);
                    }
                }

                Console.WriteLine("BROJ POKLONA NA SAJTU:" + elementi.Count);
                Console.WriteLine("BROJ OTVORENIH POKLONA: " + pokloni.Count);
               
                lblPoklonaNaSajtu.Text = "Broj poklona na sajtu: " + elementi.Count;
                lblBrInfo.Text = "Broj otvorenih poklona: " + pokloni.Count;
                int preostaliBroj = 20 - pokloni.Count;
                lblPreostalo.Text = "Preostalo poklona: " + preostaliBroj;

                if (lines[0].Trim() == elementi.Count.ToString().Trim() || elementi.Count == 0) //  provera koliko poklona postoji // ukoliko ima jedank broj kao iz fajla uradi samo refresh
                {
                    Console.WriteLine("REFRESH"); // BACI REFRESH
                    player.Stop();
                    timerJavaScript.Stop();
                    timerRefresh.Start();
                }
                else //UKOLIKO IMA RAZLICITI BROJ
                {
                    timerRefresh.Stop();
                    Console.WriteLine("PRONALAZIM POKLONE!!!");
                    int brPoklon = 1;
                    noviPokloni.Clear();

                    Boolean upisi = true;
                    foreach (var e in elementi)
                    {
                        foreach (Poklon pok in pokloni)
                        {
                            if (e.GetAttribute("style").ToString().Trim() == pok.Style.Trim())
                            {
                                upisi = false;
                                break;
                            }
                        }
                        if (upisi == true || pokloni.Count == 0)
                        {
                            Poklon p = new Poklon(pokloni.Count + 1, e.GetAttribute("style").ToString(), DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo));
                            lblVremePoklona.Text = "Vreme poklona: " + p.Vreme;
                            pokloni.Add(p);
                            noviPokloni.Add(brPoklon);
                        }
                        else
                            upisi = true;
                        brPoklon++;
                    }
                    player.PlayLooping();;
                    timerJavaScript.Start();                       
                    File.WriteAllText("info.txt", String.Empty);
                    TextWriter tw = new StreamWriter("info.txt");
                    tw.WriteLine(elementi.Count.ToString().Trim());
                    foreach (Poklon p in pokloni)
                        tw.WriteLine(p.Pozicija + "@" + p.Style + "@" + p.Vreme);
                    tw.Close();
                }
            }
            catch (Exception ex)
            {
                btnPokreniChrome.Enabled = false;
                btnStart.Enabled = true;
                btnZaustavi.Enabled = false;
                player.Stop();
                timerRefresh.Stop();
                MessageBox.Show("Naziv klase: " + this.GetType().Name + "\n Funkcija: " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\"" + ex.Message.ToString().Trim().Substring(0, Math.Min(ex.Message.ToString().Trim().Length, 350)) + "\"", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}