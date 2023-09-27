using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::   :::     :::     :::    ::: ::::::::::: ::::::::: :::::::::: :::::::::: \r\n:+:   :+:   :+: :+:   :+:    :+:     :+:          :+:  :+:        :+:        \r\n +:+ +:+   +:+   +:+  +:+    +:+     +:+         +:+   +:+        +:+        \r\n  +#++:   +#++:++#++: +#++:++#++     +#+        +#+    +#++:++#   +#++:++#   \r\n   +#+    +#+     +#+ +#+    +#+     +#+       +#+     +#+        +#+        \r\n   #+#    #+#     #+# #+#    #+#     #+#      #+#      #+#        #+#        \r\n   ###    ###     ### ###    ###     ###     ######### ########## ########## ");
            Console.WriteLine();
            Console.WriteLine("Enter player 1's name:");
            string player1Name = Console.ReadLine();
            Console.WriteLine("Enter player 2's name:");
            string player2Name = Console.ReadLine();
            Player player1 = new Player(player1Name);
            Player player2 = new Player(player2Name);
            for (int i = 0; i < 13; i++)
            {
                player1.Play();
                player2.Play();
            }
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║" + player1Name + "'s final score:                  " + " ║");
            player1.PrintScore();
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║" + player2Name + "'s final score:                  " + " ║");
            player2.PrintScore();
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("::::::::::: :::    :::     :::     ::::    ::: :::    :::  ::::::::  \r\n    :+:     :+:    :+:   :+: :+:   :+:+:   :+: :+:   :+:  :+:    :+: \r\n    +:+     +:+    +:+  +:+   +:+  :+:+:+  +:+ +:+  +:+   +:+        \r\n    +#+     +#++:++#++ +#++:++#++: +#+ +:+ +#+ +#++:++    +#++:++#++ \r\n    +#+     +#+    +#+ +#+     +#+ +#+  +#+#+# +#+  +#+          +#+ \r\n    #+#     #+#    #+# #+#     #+# #+#   #+#+# #+#   #+#  #+#    #+# \r\n    ###     ###    ### ###     ### ###    #### ###    ###  ########  ");
            Console.WriteLine("::::::::::  ::::::::  :::::::::  \r\n:+:        :+:    :+: :+:    :+: \r\n+:+        +:+    +:+ +:+    +:+ \r\n:#::+::#   +#+    +:+ +#++:++#:  \r\n+#+        +#+    +#+ +#+    +#+ \r\n#+#        #+#    #+# #+#    #+# \r\n###         ########  ###    ### ");
            Console.WriteLine(" ::::::::      :::     ::::    ::::  ::::    ::::  ::::::::::: ::::    :::  ::::::::  \r\n:+:    :+:   :+: :+:   +:+:+: :+:+:+ +:+:+: :+:+:+     :+:     :+:+:   :+: :+:    :+: \r\n+:+         +:+   +:+  +:+ +:+:+ +:+ +:+ +:+:+ +:+     +:+     :+:+:+  +:+ +:+        \r\n:#:        +#++:++#++: +#+  +:+  +#+ +#+  +:+  +#+     +#+     +#+ +:+ +#+ :#:        \r\n+#+   +#+# +#+     +#+ +#+       +#+ +#+       +#+     +#+     +#+  +#+#+# +#+   +#+# \r\n#+#    #+# #+#     #+# #+#       #+# #+#       #+#     #+#     #+#   #+#+# #+#    #+# \r\n ########  ###     ### ###       ### ###       ### ########### ###    ####  ########  ");
            Console.ReadLine();
        }
    }
}
