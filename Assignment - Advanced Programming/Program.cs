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
                    // 1. Add Music Disc.
                    case UserOption.add_musicDisc:
                        do
                        {
                            inputDisc = UserInterface.addDisc();
                            switch (inputDisc)
                            {
                                // Add EDM Disc
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
                                //End

                                // Add POP Disc
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
                                //End

                                default:
                                    WriteLine(" There is no choice you want in this menu option, please try again!");
                                    WriteLine();
                                    break;
                            }
                        } while (inputDisc != UserOption.exit_add_type_musicDisc);
                        break;
                    // End.

                    // 2. Show Information Of All Disc.
                    case UserOption.show_info_of_all_disc:
                        WriteLine(musicDiscShop.PrintAllDisc());
                        break;
                    // End.

                    // 3. Show EDM Music Disc.
                    case UserOption.show_edm:
                        break;
                    // End.

                    // 4. Show POP Music Disc.
                    case UserOption.show_pop:
                        break;

                    // 5. Show Music Disc By Id.
                    case UserOption.show_by_id:
                        WriteLine(musicDiscShop.GetMusicDiscById(UserInterface.enterID()));
                        break;

                    // 6. Show Music Disc By Name.
                    case UserOption.show_by_name:
                        WriteLine(musicDiscShop.GetMusicDiscsByName(UserInterface.enterName()));
                        break;

                    // 7. Show Music Disc By Name Of Artist.
                    case UserOption.show_by_name_of_artist:
                        WriteLine(musicDiscShop.GetMusicDiscByArtist(UserInterface.enterArtist()));
                        break;

                    // 8. Remove Disc By Id.
                    case UserOption.remove_by_id:
                        WriteLine(UserInterface.messageChoice(
                                    musicDiscShop.DeleteById(UserInterface.enterID())));
                        break;

                    // 9. Update Disc By Id.
                    case UserOption.update_by_id:
                        WriteLine(UserInterface.messageChoice(
                                    musicDiscShop.UpdateById(UserInterface.enterID())));
                        break;

                    // 0. Exit.
                    case UserOption.exit:
                        WriteLine(" Thank You For Using Our System !!");
                        return;

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
        UserInterface.Header();
        Option(musicDiscShop);
    }
}