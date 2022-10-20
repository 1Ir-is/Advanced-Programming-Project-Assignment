using Assignment___Advanced_Programming;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        MusicDiscShop musicDiscShop = new MusicDiscShop();
        int input = UserOption.enter_choice;
        string inputDisc = UserOption.add_type_musicDisc;
        MusicDisc musicDisc = new EdmMusicDisc();
        MusicDisc musicDisc1 = new PopMusicDisc();
        do
        {
            input = UserInterface.menuOption();
            switch (input)
            {
                // 1. Add Music Disc.
                case UserOption.add_musicDisc:
                    do
                    {
                        inputDisc = UserInterface.addDisc();
                        switch (inputDisc)
                        {
                            // add EDM disc
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

                            // add POP disc
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
                            default:
                                break;
                        }
                    } while (inputDisc != UserOption.exit_add_type_musicDisc);
                    break;
                // End.

                // 2. Show Information Of All Disc.
                case UserOption.show_info_of_all_disc:
                    break;
                // End.

                // 3. Show EDM Music Disc.
                case UserOption.show_edm:
                    break;
                // End.

                // 4. Show POP Music Disc.
                case UserOption.show_pop:
                    musicDisc1.DisplayMusicInfo();
                    break;

                // 5. Show Music Disc By Id.
                case UserOption.show_by_id:
                    musicDiscShop.FindDiscById(UserInterface.enterID());
                    break;

                // 6. Show Music Disc By Name.
                case UserOption.show_by_name:
                    musicDiscShop.GetMusicDiscsByName(UserInterface.enterName());
                    break;

                // 7. Remove Disc By Id.
                case UserOption.remove_by_id:
                    musicDiscShop.DeleteById(UserInterface.enterID());
                    break;

                // 8. Update Disc By Id.
                case UserOption.update_by_id:
                    musicDiscShop.UpdateById(UserInterface.enterID());
                    break;

                // 0. Exit.
                case UserOption.exit:
                    return;
                default:
                    break;
            }
        } while (input != UserOption.exit);
    }
}