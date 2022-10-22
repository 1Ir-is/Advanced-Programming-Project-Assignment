using Assignment___Advanced_Programming;
using System;
using static System.Console;

class Program
{
    static void Option(MusicDiscShop musicDiscShop)
    {
        int input = UserOption.enter_choice;
        string inputDisc = UserOption.add_type_musicDisc;
        do
        {
            try
            {
                input = UserInterface.menuOption();
                WriteLine();
                switch (input)
                {
                    // 1. ADD MUSIC DISC.
                    case UserOption.add_musicDisc:
                        do
                        {
                                inputDisc = UserInterface.addDisc();
                                switch (inputDisc)
                                {
                                    // ADD EDM MUSIC DISC.
                                    case UserOption.add_EDM:
                                        try
                                        {
                                            musicDiscShop.AddMusicDisc(new EdmMusicDisc(
                                              UserInterface.enterID(),
                                              UserInterface.enterName(),
                                              UserInterface.enterArtist(),
                                              UserInterface.enterDescription(),
                                              UserInterface.enterYear(),
                                              UserInterface.enterPrice()));
                                        }
                                        catch (ArgumentException e)
                                        {
                                            WriteLine(e.Message);
                                        }
                                        break;
                                    // END.

                                    // ADD POP MUSIC DISC.
                                    case UserOption.add_POP:
                                        try
                                        {
                                            musicDiscShop.AddMusicDisc(new PopMusicDisc(
                                              UserInterface.enterID(),
                                              UserInterface.enterName(),
                                              UserInterface.enterArtist(),
                                              UserInterface.enterDescription(),
                                              UserInterface.enterYear(),
                                              UserInterface.enterPrice()));
                                        }
                                        catch (ArgumentException e)
                                        {
                                            WriteLine(e.Message);
                                        }
                                        break;
                                    // END.

                                    // EXIT ADD DISC MENU.
                                    case UserOption.exit_add_type_musicDisc:
                                         WriteLine();
                                         WriteLine(" Exit success!");
                                         WriteLine();
                                    break;
                                    // END.

                                    default:
                                        WriteLine();
                                        WriteLine(" There is no choice you want in the menu option, please try again!");
                                        WriteLine();
                                        break;
                                }
                        } while (inputDisc != UserOption.exit_add_type_musicDisc);
                        break;
                    // END.


                    // 2. SHOW INFORMATION OF ALL DISC.
                    case UserOption.show_info_of_all_disc:
                        WriteLine(musicDiscShop.PrintAllDisc());
                        break;
                    // End.


                    // 3. SHOW EDM MUSIC DISC.
                    case UserOption.show_edm:
                        musicDiscShop.PrintAllEdm();
                        break;
                    // End.


                    // 4. SHOW POP MUSIC DISC.
                    case UserOption.show_pop:
                        break;
                    // END.


                    // 5. SHOW MUSIC DISC BY ID.
                    case UserOption.show_by_id:
                        WriteLine(musicDiscShop.GetMusicDiscById(UserInterface.enterID()));
                        break;
                    // END.


                    // 6. SHOW MUSIC DISC BY NAME.
                    case UserOption.show_by_name:
                        WriteLine(musicDiscShop.GetMusicDiscsByName(UserInterface.enterName()));
                        break;
                    // END.


                    // 7. SHOW MUSIC DISC BY NAME OF ARTIST.
                    case UserOption.show_by_name_of_artist:
                        WriteLine(musicDiscShop.GetMusicDiscByArtist(UserInterface.enterArtist()));
                        break;
                    // END.


                    // 8. REMOVE DISC BY ID.
                    case UserOption.remove_by_id:
                        WriteLine(UserInterface.messageChoice(
                                    musicDiscShop.DeleteById(UserInterface.enterID())));
                        break;
                    // END.


                    // 9. UPDATE DISC BY ID.
                    case UserOption.update_by_id:
                        WriteLine(UserInterface.messageChoice(
                                    musicDiscShop.UpdateById(UserInterface.enterID())));
                        break;
                    // END.


                    // 0. EXIT.
                    case UserOption.exit:
                        WriteLine(" Thank You For Using Our System !!");
                        return;
                    // END.


                    default:
                        WriteLine(" There is no choice you want in the menu option, please try again!");
                        WriteLine();
                        break;
                }
            }
            catch (Exception)
            {
                WriteLine();
                WriteLine(" Invalid input, please try again!");
                WriteLine();
            }
        } while (input != 11);
    }

    static void Main(string[] args)
    {
      
        MusicDiscShop musicDiscShop = new MusicDiscShop();
        musicDiscShop.AddMusicDisc(new EdmMusicDisc(1, "TO THE MOON", "IRIS", "THIS IS EDM MUSIC", 2022, 10));


        musicDiscShop.AddMusicDisc(new PopMusicDisc(10, "I LOVE YOU", "HUY", "THIS IS POP MUSIC", 2022, 15));

        UserInterface.Header();
        Option(musicDiscShop);
    }
}