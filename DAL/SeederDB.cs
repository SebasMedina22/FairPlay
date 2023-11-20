namespace GestionTorneoFutbol.DAL.Entities
{

    public class SeederDB
    {
        private readonly DataBaseContext _context;

        public SeederDB(DataBaseContext context)
        {
            _context = context;
        }
        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();


            await PopulatePlayersAsync();
            //await PopulateFairPlayAsync();

            await _context.SaveChangesAsync();
        }

        #region Private Methos
        //Overpopulate the teams table with their respective players and Fair Play
        private async Task PopulatePlayersAsync()

        {
            if (!_context.Teams.Any())
            {
                #region Equipo 1 
                _context.Teams.Add(new Team
                {
                    Name = "Arsenal FC",
                    Technical = "Mikel Arteta",
                    FairPlays = new List<FairPlay>()
                    {
                        new FairPlay
                        {
                            ModifiedDate = DateTime.Now,
                            Date=01012023,
                            RedCard=5,
                            YellowCard=10,
                            Points=125
                        }
                    },
                    Players = new List<Player>()
                    {
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 111,
                        Name= "Aaron Ramsdale",
                        Number = 1,
                        Goals = 0,
                        State = true
                    },
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 222,
                        Name= "Emile Smith Rowe",
                        Number = 10,
                        Goals = 0,
                        State = true
                    },
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 333,
                        Name= "Leandro Trossard",
                        Number = 4,
                        Goals = 0,
                        State = true
                    },
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 444,
                        Name= "Reiss Nelson",
                        Number = 24,
                        Goals = 0,
                        State = true
                    },
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 555,
                        Name= "Eddie Nketiah",
                        Number = 14,
                        Goals = 0,
                        State = true
                    },
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 666,
                        Name= "Gabriel Jesus",
                        Number = 52,
                        Goals = 0,
                        State = true
                    },
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 777,
                        Name= "Cédric Soares",
                        Number = 26,
                        Goals = 0,
                        State = true
                    },
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 888,
                        Name= "Oleksandr Zinchenko",
                        Number = 77,
                        Goals = 0,
                        State = true
                    },
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 999,
                        Name= "William Saliba",
                        Number = 35,
                        Goals = 0,
                        State = true
                    }
                    }
                });
                #endregion

                #region Equipo 2
                _context.Teams.Add(new Team
                {
                    CreatedDate = DateTime.Now,
                    Name = "Chelsea FC",
                    Technical = "Thomas Tuchel",
                    FairPlays = new List<FairPlay>()
                    {
                        new FairPlay
                        {
                            ModifiedDate = DateTime.Now,
                            Date=02022023,
                            RedCard=1,
                            YellowCard=2,
                            Points=20
                        }
                    },
                    Players = new List<Player>()
                {
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 112,
                        Name= "Djordje Petrovic",
                        Number = 1,
                        Goals = 0,
                        State = true
                    },

                     new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 223,
                        Name= "Lucas Bergström",
                        Number = 25,
                        Goals = 0,
                        State = false
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 334,
                        Name= "Thiago Silva",
                        Number = 6,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 445,
                        Name= "Ian Maatsen",
                        Number = 55,
                        Goals = 0,
                        State = false
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 556,
                        Name= "Declan Rice",
                        Number = 45,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 667,
                        Name= "Enzo Fernández",
                        Number = 71,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 778,
                        Name= "Conor Gallagher",
                        Number = 59,
                        Goals = 0,
                        State = true
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 889,
                        Name= "Moisés Caicedo",
                        Number = 37,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 991,
                        Name= "Ronnie Stutter",
                        Number = 5,
                        Goals = 0,
                        State = true
                    }
                }
                });
                #endregion

                #region Equipo 3
                _context.Teams.Add(new Team
                {
                    CreatedDate = DateTime.Now,
                    Name = "Manchester City FC",
                    Technical = "Pep Guardiola",
                    FairPlays = new List<FairPlay>()
                    {
                        new FairPlay
                        {
                            ModifiedDate = DateTime.Now,
                            Date=03032023,
                            RedCard=2,
                            YellowCard=3,
                            Points=35
                        }
                    },
                    Players = new List<Player>()
                {
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 122,
                        Name= "Rúben Dias",
                        Number = 1,
                        Goals = 0,
                        State = true
                    },

                     new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 233,
                        Name= "Manuel Akanji",
                        Number = 65,
                        Goals = 0,
                        State = false
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 344,
                        Name= "Rico Lewis",
                        Number = 16,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 455,
                        Name= "Matheus Nunes",
                        Number = 57,
                        Goals = 0,
                        State = false
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 566,
                        Name= "Erling Haaland",
                        Number = 9,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 677,
                        Name= "Bernardo Silva",
                        Number = 7,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 788,
                        Name= "John Stones",
                        Number = 10,
                        Goals = 0,
                        State = true
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 899,
                        Name= "Kyle Walker",
                        Number = 3,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 911,
                        Name= "Scott Carson",
                        Number = 22,
                        Goals = 0,
                        State = true
                    }
                }
                });
                #endregion

                #region Equipo 4
                _context.Teams.Add(new Team
                {
                    CreatedDate = DateTime.Now,
                    Name = "Manchester United FC",
                    Technical = "Ole Gunnar Solskjær",
                    FairPlays = new List<FairPlay>()
                    {
                        new FairPlay
                        {
                            ModifiedDate = DateTime.Now,
                            Date=04042023,
                            RedCard=3,
                            YellowCard=4,
                            Points=50
                        }
                    },
                    Players = new List<Player>()
                {
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 121,
                        Name= "Altay Bayindir",
                        Number = 11,
                        Goals = 0,
                        State = true
                    },

                     new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 232,
                        Name= "Victor Lindelöf",
                        Number = 14,
                        Goals = 0,
                        State = false
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 343,
                        Name= "Raphaël Varane",
                        Number = 21,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 454,
                        Name= "Donny van de Beek",
                        Number = 55,
                        Goals = 0,
                        State = false
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 565,
                        Name= "Alejandro Garnacho",
                        Number = 6,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 676,
                        Name= "Shola Shoretire",
                        Number = 34,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 787,
                        Name= "Kobbie Mainoo",
                        Number = 65,
                        Goals = 0,
                        State = true
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 898,
                        Name= "Jonny Evans",
                        Number = 94,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 919,
                        Name= "Luke Shaw",
                        Number = 55,
                        Goals = 0,
                        State = true
                    }
                }
                });
                #endregion

                #region Equipo 5
                _context.Teams.Add(new Team
                {
                    CreatedDate = DateTime.Now,
                    Name = "Everton FC",
                    Technical = "Rafael Benítez",
                    FairPlays = new List<FairPlay>()
                    {
                        new FairPlay
                        {
                            ModifiedDate = DateTime.Now,
                            Date=05052023,
                            RedCard=4,
                            YellowCard=5,
                            Points=65
                        }
                    },
                    Players = new List<Player>()
                {
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 123,
                        Name= "Jordan Pickford",
                        Number = 11,
                        Goals = 0,
                        State = true
                    },

                     new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 124,
                        Name= "Nathan Patterson",
                        Number = 14,
                        Goals = 0,
                        State = false
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 125,
                        Name= "Séamus Coleman",
                        Number = 21,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 126,
                        Name= "Arnaut Danjuma",
                        Number = 55,
                        Goals = 0,
                        State = false
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 127,
                        Name= "Lewis Dobbin",
                        Number = 6,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 128,
                        Name= "Idrissa Gueye",
                        Number = 34,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 129,
                        Name= "Ashley Young",
                        Number = 65,
                        Goals = 0,
                        State = true
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 130,
                        Name= "Dele Alli",
                        Number = 94,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 120,
                        Name= "Youssef Chermiti",
                        Number = 55,
                        Goals = 0,
                        State = true
                    }
                }
                });
                #endregion

                #region Equipo 6
                _context.Teams.Add(new Team
                {
                    CreatedDate = DateTime.Now,
                    Name = "Liverpool FC",
                    Technical = "Jürgen Klopp",
                    FairPlays = new List<FairPlay>()
                    {
                        new FairPlay
                        {
                            ModifiedDate = DateTime.Now,
                            Date=06062023,
                            RedCard=5,
                            YellowCard=6,
                            Points=80
                        }
                    },
                    Players = new List<Player>()
                {
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 131,
                        Name= "Alisson Becker",
                        Number = 11,
                        Goals = 0,
                        State = true
                    },

                     new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 132,
                        Name= "Caoimhín Kelleher",
                        Number = 14,
                        Goals = 0,
                        State = false
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 133,
                        Name= "Andy Robertson",
                        Number = 21,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 134,
                        Name= "Calum Scanlon",
                        Number = 55,
                        Goals = 0,
                        State = false
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 135,
                        Name= "Trent Alexander-Arnold",
                        Number = 6,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 136,
                        Name= "Dominik Szoboszlai",
                        Number = 34,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 137,
                        Name= "Kaide Gordon",
                        Number = 65,
                        Goals = 0,
                        State = true
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 138,
                        Name= "Harvey Elliott",
                        Number = 94,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 139,
                        Name= "Jarell Quansah",
                        Number = 55,
                        Goals = 0,
                        State = true
                    }
                }
                });
                #endregion

                #region Equipo 7
                _context.Teams.Add(new Team
                {
                    CreatedDate = DateTime.Now,
                    Name = "Tottenham Hotspur FC",
                    Technical = "Nuno Espírito Santo",
                    FairPlays = new List<FairPlay>()
                    {
                        new FairPlay
                        {
                            ModifiedDate = DateTime.Now,
                            Date=07072023,
                            RedCard=6,
                            YellowCard=7,
                            Points=95
                        }
                    },
                    Players = new List<Player>()
                {
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 241,
                        Name= "Fraser Forster",
                        Number = 1,
                        Goals = 0,
                        State = true
                    },

                     new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 242,
                        Name= "Alfie Whiteman",
                        Number = 11,
                        Goals = 0,
                        State = false
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 243,
                        Name= "Ashley Phillips",
                        Number = 31,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 244,
                        Name= "Yves Bissouma",
                        Number = 56,
                        Goals = 0,
                        State = false
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 245,
                        Name= "Giovani Lo Celso",
                        Number = 6,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 246,
                        Name= "Manor Solomon",
                        Number = 34,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 247,
                        Name= "Son Heung-Min",
                        Number = 65,
                        Goals = 0,
                        State = true
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 248,
                        Name= "Oliver Skipp\r\n",
                        Number = 94,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 249,
                        Name= "Pierre-Emile Højbjerg",
                        Number = 55,
                        Goals = 0,
                        State = true
                    }
                }
                });
                #endregion

                #region Equipo 8
                _context.Teams.Add(new Team
                {
                    CreatedDate = DateTime.Now,
                    Name = "Aston Villa FC",
                    Technical = "Steven Gerrard",
                    FairPlays = new List<FairPlay>()
                    {
                        new FairPlay
                        {
                            ModifiedDate = DateTime.Now,
                            Date=08082023,
                            RedCard=7,
                            YellowCard=8,
                            Points=110
                        }
                    },
                    Players = new List<Player>()
                {
                    new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 381,
                        Name= "Emiliano Martínez",
                        Number = 11,
                        Goals = 0,
                        State = true
                    },

                     new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 382,
                        Name= "Ezri Konsa",
                        Number = 14,
                        Goals = 0,
                        State = false
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 383,
                        Name= "Pau Torres",
                        Number = 21,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 384,
                        Name= "John McGinn",
                        Number = 55,
                        Goals = 0,
                        State = false
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 385,
                        Name= "Tim Iroegbunam",
                        Number = 6,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 386,
                        Name= "Ollie Watkins",
                        Number = 34,
                        Goals = 0,
                        State = true
                    },
                         new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 387,
                        Name= "Tommi O'Reilly",
                        Number = 65,
                        Goals = 0,
                        State = true
                    },
                       new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 389,
                        Name= "Douglas Luiz",
                        Number = 94,
                        Goals = 0,
                        State = true
                    },
                        new Player
                    {
                        CreatedDate = DateTime.Now,
                        Document = 380,
                        Name= "Álex Moreno",
                        Number = 55,
                        Goals = 0,
                        State = true
                    }
                }
                });
                #endregion
            }
        }

        //Prueba seeder, esto en teoria no funciona ya que se necesita el team ID para inicializar el registro en cada equipo
        //Pero a la hora de hacerlo arriba en populatePlayers, donde se crea el equipo, lo intento y no funciona.

        /*private async Task PopulateFairPlayAsync()
        {
            if (!_context.FairPlays.Any())
            {
                _context.FairPlays.AddRange(new FairPlay
                {
                    Date = 01012023,
                    RedCard = 5,
                    YellowCard = 6,
                    Points = 80,
                    //ID_Team= bcec74b4-7170-47a5-c865-08dbe72f681f
                });
            }

        }*/
    }

    #endregion
}
