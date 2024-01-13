using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        static void introduction()
        {
            Console.WriteLine("Vždycky si věděl, že si trochu jiný. Jakmile si se vyskytoval poblíž vody," +
                "měl si takový zvláštní pocit a k moři tě to odjakživa přímo táhlo. Teď stojíš se svými " +
                "dvěmi přátely na palubě lodi někde uprostřed Atlanského oceánu. Ještě chvíli vyčkáváte " +
                "a pak zahájíte ponor. Plaveš první. Při potápění před sebou uvidíš jeskyňku. Plaveš se " +
                "tam podívat, ale když si všimneš, že tvoji přátelé s tebou nejspu, vyplaveš zpět. Ani tady " +
                "je však nevidíš. Zoufale se rozhlížíš a snažíš se je najít, když však na mořském dnu " +
                "zpozoruješ vzduchovou bublinu a v ní trosky paláce. Doplaveš tam a když překonáš " +
                "vzduchovou bariéru, můžeš po dně normálně chodit a dýchat. Dojdeš k zachované části paláce, " +
                "otevřeš staře vypadající dveře a vstoupíš. Dveře se za tebou zavřou. Zkoušíš je ještě " +
                "otevřít, ale nejde to. Najednou se však v místnosti rozsvítí a ty se můžeš rozhlédnout " +
                "kolem sebe.");
        }
        static void startingRoom()
        {
            Console.WriteLine("Stojíš uprostřed velké místnosti, kde se nachází dvoje dveře. Jedny vypadají " +
                "velmi staře a ty druhé naopak poměrně moderně. Vedle nich si ještě všimneš chodby. " +
                "Po krátkém uvažování se to tu rozhodneš prozkoumat. Kam se vydáš jako první? " +
                "(Pro výběr starých dveří napiš sd, pro modermí dveře md a pro chodbu ch)");
        }
        static void startingRoomReturn()
        {
            Console.WriteLine("Opět stojíš uprostřed velké místnosti kde jsi začínal. Kam se vydáš tentokrát?");
        }
        static void oldDoorKey()
        {
            Console.WriteLine("Vydáš se ke starým dveřím. Chvíli koukáš na otvor zámku, kterého si všimneš, " +
                "ale pak si vspomeneš, že držíš v ruce starý klíč. Zkusíš ho zasunout do zámku. Sedí tam. " +
                "Pomalu klíčem otočíš, vezmeš za kliku a vstoupíš. Dveře se za tebou zabouchnou a nejde je " +
                "znovu otevřít. Musíš tedy pokračovat dál.");
        }
        static void oldDoorNotKey()
        {
            Console.WriteLine("Vydáš se ke starým dveřím. Všimneš si starého zámku na nich a uvědomíš si," +
                "že nemáš žádný klíč. Zkusíš vzít za kliku a doufáš že nejsou zamčené. Dveře se ti všek " +
                "otevřít nepodaří.Budeš se sem muset vrátit znovu, až budeš mít klíč");
        }
        static void modernDoor()
        {
            Console.WriteLine("Vydáš se k moderně vypadajícím dveřím, ale všimneš si, že pro vstup " +
                "potřebuješ zadat kód.(Pokud myslíš že znáš kod zkus ho zadat. Pokud myslíš že ne, " +
                "můžeš zadat cokoliv jiného a k dveřím se vrátit později.");
        }
        static void wrongCode()
        {
            Console.WriteLine("Protože neznáš kód, odchazíš od dveří a seš rozhodnutý se sem vrátit později");
        }
        static void correctCode()
        {
            Console.WriteLine("Dveře se před tebou otevřou. Vstoupíš do místnosti, kde je poměrně šero." +
                "V tom uslyšíš hlas: Je-li ti život milý, dál nechoď. Nacházíš se ve starém chrámu " +
                " Atlantidy. Bohové se pro lidskou chamtivost a nepoctivost rozhodli tento kontinent " +
                "potopit ppod vlnou tsunami.Chtěli však zachránit tento chrám a pár dobrých lidí. Mě " +
                "pověřili abych tyto lidi schromáždil v tomto chrámu. Mě se ale zželelo těch ostatních " +
                "a pozval jsem je do chrámu také. Za to bohové zničili všechno a všechny a chrám pohřbyli " +
                "pod vodní hladinu.Mě zakleli do stvůry tak hrozné, že při pohledu na ní, zemře každý " +
                "liský tvor. Proto snesmíš jit dál, aby si mě neviděl. Atlantidu může zachránit pouze člověk " +
                "s čistým srdcem předurčený bohy. Jseš-li to ty, zvládneš to. Pokud to ale nejsi ty, " +
                "zůstaneš v chrámu až do jeho osvobození. Můžu ti všek pomoci. Vyřešíš li mou hádanku," +
                " řeknu ti část poslední hádanky a kde hledat klíč ke starým dveřím ve velké místnosti. " +
                "Hádanka zní");
        }
        static void correctAnswerRiddle2()
        {
            Console.WriteLine("Výborně. Ozve se znovu hlas. Vyřešil si mou hádanku. Část poslední hádanky " +
                "je 9279526D4. Dobře si to zapamatuj, budeš to potřebovat. Klíč najdeš ve výklenku v pravou, " +
                "než vyjdeš ze dveří. Poděkuješ a vydáš se zpět. Cestou najdeš klič přesně podle instrukcí.");
        }
        static void playerWereInModernDoor()
        {
            Console.WriteLine("Přijdeš znovu k moderním dveřím, ale kód nakonec nezadáš. Vzpomeneš si na " +
                "varování, že každý, kdo uvidí stvůru v nich, zemře a raději se zase vrátíš.");
        }
        static void corridor()
        {
            Console.WriteLine("Vydáš se do chodby, ale ta po pár zatáčkách skončí zaslepením. Na jejím " +
                "koci je však text který vypadá jako zadání nějaké úlohy. Řekneš si že tam určitě není " +
                "napsaný jen tak a tak se rozhodneš si ji přečíst, protože její řešení by se ti mohlo " +
                "hodit. (Až se budeš chtít vráti zadej h). Zadání hádanky je: ");
        }
        static void hall()
        {
            Console.WriteLine("Chvilku ještě stojíš a prohlížíš si, kde si se to vlastně ocitl. Stojíš " +
                "uprostřd velké místnosti po jejímž obvozu je spousta antických sloupů. Všimneš si že " +
                "některé spolehlivě podpírají střechu, zatímco jiné jsou v celku jen do poloviny a pak " +
                "jsou rozbořené. Nemáš z toho moc dobrý pocit a rozhodneš se raději pokračovat. Na výběr " +
                "máš ale dvě chodby. Jednu doprava a jednu doleva. Kam se rozhodneš jít? " +
                "(PRo cestu v pravo napiš p a pro cestu v levo l)");
        }
        static void hallAgain()
        {
            Console.WriteLine("Znovu stojíš uprostřed velké místnosti se sloupy. Opět ti něco říká že to " +
                "tam nění úplně bezpečné a tak chceš rychle odejít. kam půjdeš? do prava nebo do leva?");
        }
        static void leftCorridor()
        {
            Console.WriteLine("Vydáš se do levé chodby. Chvíli jdeš, ale brzy dojdeš k rozdělení. Odtud vedou " +
                "dvě cesty. Jedna je osvětlená a v druhé je tma. Kterou cestu si vybereš? " +
                "(Pro osvetlenou chodbu napiš s a pro tmavou t)");
        }
        static void rightCorridorWithFlute()
        {
            Console.WriteLine("Vydáš se do pravé chodby, ale po pár krocích si všimneš velikého koše. " +
                "Dojdeš k němu blíž, ale všimneš si obrovské kobry v něm která se začne zvedat a zlověstně " +
                "sičet. Vzpomeneš si však, že držíš v ruce flétnu. Zkusíš na ní zahrát svou oblíbenou " +
                "píseň a had se začne sklidňovat. Když dohraješ, začne na tebe kobra mluvit: Děkuji, že si " +
                "mi tak krásně zahrál. Dlouho jsem neslyšela hudbu, kterou tak miluji. Za to ti dám hádanku " +
                "a když ji zvladneš vyřešit, pustím tě tě dál a k tomu ti řeknu část poslední hádanky. " +
                "Moje hádanka zní: ");
        }
        static void rightCorridorWithoutFlute()
        {
            Console.WriteLine("Vydáš se do pravé chodby, ale po pár krocích si všimneš velikého koše. " +
                "Dojdeš k němu blíž, ale všimneš si obrovské kobry v něm která se začne zvedat a zlověstně " +
                "sičet. Nevíš co máš dělat a tak se raději otočíš a vátíš zpet do místnosti se sloupy");
        }
        static void litCorridor()
        {
            Console.WriteLine("Pokračuješ dál osvětlenou chodbou, ale bohužel zjistíš, že vede zpět " +
                "do místnosti se slopy.");
        }
        static void darkCorridor()
        {
            Console.WriteLine("Pokračuješ dál tmavou chodbou. Chvíli jdeš když v tom o něco zakopneš. " +
                "Pokusíš se věc nahmatat a zjistíš že je to flétna. Vezmeš ji sebou protože by se mohla " +
                "později hodit. Poté uvidíš na konci chodby světlo a když už je v chodbě trochu vidět " +
                "uvidíš na stěně něco co by mohla být další čáat hádanky jak o ní mluvila ta nestvůra. " +
                "Je tam napsáno 034BUDS1. Poté z chodby vyjdeš");
        }
        static void darkCorridorReturn()
        {
            Console.WriteLine("Zkusíš projít tmavou chodbou ještě jednou, ale na nic zajímavého už nenarazíš");
        }
        static void correctAnswerRiddle3()
        {
            Console.WriteLine("Tvá odpověď je správná. Kobra tě pustí ddál a dozvíš se od ní, že část " +
                "poslední hádanky je 8Z6V42U. Procházíš dál chodbou, když uslyšíš za sebou obrovskouránu. " +
                "Ohlídneš se za sebe a uvidíš že trámy které podpírali strop nevydrželi větší tíhu než " +
                "mají nést a strop v místnosti i v chodbě se postupně sesouvá k zemi. Rozběhneš se tedy " +
                "chodbou a běžíš až do další místnosti. Teprve tam si všimneš že propadání stropu už se " +
                "zastavilo a ty jsi v bezpečí. chodba za tebou je zasypaná sutinami a ty tedy musíš " +
                "pokračovat dál. Rozhlédneš se po místnosti ale jsou tu jen holé stěny. Najednou tě napadne " +
                "podívat se ještě na strop a tam uvidíš text. Už víš že je to bude nejspíš zadání nějaké " +
                "hádanky kterou musíš vyřešit aby si mohl projit dál (řešení zadávej malými písmeny bez " +
                "háčků a čárek). Na stropě je napsáno:");
        }
        static void correctAnswerRiddle4()
        {
            Console.WriteLine("Když zjistíš řešení hádanky tak začneš hledat kam se dá řešení zadat " +
                "nebo komu ho říct. Nic ani nikoho však nevidíš a tak tě napadne řešení nahlas vyslovit. " +
                "K tvému překvapení se ve zdi před tebou vytvoří dveře a otevřou se. Chvíli ještě váháš, " +
                "ale nakonec projdeš otvorem vezdi. Sotva tak ale učiníš dveře se opět zacelý a na jejich " +
                "původním místě si všimneš poslední části potřebné pro posledbí hádanku. je tam napsano: " +
                "petronilka=0123456789. Pokračuješ dál až dojdeš do místnosti kde je na stěně nápis: ");
        }
        static void Answer()
        {
            Console.WriteLine("Zatím si nezadal správné řešení hádanky.Napiš ho sem:");
        }
        static void error()
        {
            Console.WriteLine("Tato varianta nebyla na výběr. Vyber znovu.");
        }
        static void Riddle5()
        {
            Console.WriteLine("Poslední hádanka otestuje i jak si byl během cesty pozorný. Kousky zadání " +
                "ti mohl někdo cestou prozradit, nebo byly někde napsané. Spoj si tyto kusy dohromady a " +
                "získáš poslední hádanku. Její řešení napiš na podlahu křídou, která leži pod tímto " +
                "napisem (odpověď napiš malými písmeny bez háčků a čárek)");
        }
        static void end()
        {
            Console.WriteLine("Sotva si dopsal řešení, země se začne chvět a ty cítíš že se podlaha s " +
                "tebou zvedá. Najednou tě oslní silné světlo a ty jsi nucený zavřít oči. Když je po " +
                "nějaké chvíli otevřeš vídíš chrám, který vyoadá jako nový. Dlouhé temné chodby se " +
                "změnili v krátké průchody a chrámem, který byl předtím osvětlen jen svíčkami, pronikají " +
                "paprsky slunce. K tobě přistupuje krásná dívka a mladý muž. Z jejich vyprávění se dozvíš, " +
                "že jsou sourozenci a to oni byli proměněni v nestvůru a kobru. Vyjdete společně ven " +
                "z kláštera a před vámi se rozprostírá krásná příroda znovu oběveného kontinentu atlantida. " +
                "Na obzoru uvidíš loď co se postupně přibližuje k pobřeží nedaleko odtud a na pevninu z ní " +
                "vystouzpí tví přátelé. Se svími starými i novými přateli pak ještě dlouho diskutujete jak " +
                "obnovit život na Atlantidě, ale nakonec se shodnete, že s lidskou povahou by to " +
                "směřovalo znovu ke stejnému konci. Poprosíte tedy bohy aby zachovali tuto zem divé zvěři " +
                "a skryjí ji před lidským okem. Bohové souhlasí, ale protože poznali, že máte čisté srdce " +
                "nechají vám pěti možnost na atlantidu kdykoliv vstoupit, pokud dodržíte, že o její " +
                "existenci nikomu neřeknete. Ještě za mnoho let budou někteří hledat na mořském dnu " +
                "bájnou Atlantidu, ale tu už tam nikdy nemůžou najit. Je totiž již řadu let nalezena, " +
                "ale všem lidským bytostem skryta. Možna jen člověk v nouzi s čistým srdcem bude moci " +
                "oběvit tento starodávný kontinent s chrámem, který je posledním pozůstatkem starého města, " +
                "ale určitě ho nikdy nenajde na mořském dně. KONEC, hru se ti podařilo úspěšně dohrát.");
        }
        static void Main(string[] args)
        {
            riddle riddle1 = new riddle();
            riddle1.task = "Na mořském dně leží 7 mušlí. Po správném seřazení do řady, se otevře skála " +
                "a lze vstoupit. Možná k tomu ale postačí vědět kolik existuje různých seřazení těchto " +
                "sedmi mušlí";
            riddle1.solving = "5040";

            riddle riddle2 = new riddle();
            riddle2.task = "O jednom vysoce postaveném úředníkovi na Atlantidě všichni věděli, že nemá " +
                "žádného syna, ale má několik dcer. Nikomu však nebyl ochotný říci kolik dcer má " +
                "a všichni věděli jen, že všechny jeho dcery jsou blondýny až na dvě. Zároveň jsou ale " +
                "všechny jeho dcery brunety až na dvě a stejně tak jsou všechny až na dvě zrzky. KOlik " +
                "měl tedy tento úředník dcer? (Napiš číslem)";
            riddle2.solving = "3";

            riddle riddle3 = new riddle();
            riddle3.task = "Jeden slepý chlapec chtěl své dívce přinést dvě stejné mašle do vlasů a věděl," +
                "že z mašlí co doma našel jsou 3 bílé, 2 červené a 1 modrá, ale neví která je která. " +
                "Kolik nejméně mašlí má dívce donést aby měl jistotu, že budou elespoň 2 stejné(řešení napiš číslem)";
            riddle3.solving = "4";

            riddle riddle4 = new riddle();
            riddle4.task = "oooololoooloiooliiilloiiilollooolioiloiloiooliiilliiililoloooiloioloollooololll";
            riddle4.solving = "skalo otevri se";

            riddle riddle5 = new riddle();
            riddle5.solving = "atlantido probud se k zivotu";

            player myPlayer = new player(false, false, false, false, false, false);
            string choice, answer, hallReturn;
            answer = "";

            //Do konzole se vypíše úvodní text k celé hře
            introduction();

            while(myPlayer.state == false)
            {
                /*hráč začíná v úvodní místnosti.Podle toho zda je v této možnosti poprvé nebo se sem vrací
                vypíše mu konzole text. Poté si může vybrat kam se přesune a podle toho se vypíše děj*/
                if (myPlayer.startingRoom == false)
                {
                    startingRoom();
                    myPlayer.startingRoom = true;
                }
                else
                {
                    startingRoomReturn();
                }

                choice = Console.ReadLine();
                switch (choice) 
                {
                    case "sd":
                        //hráč si vybral staré dveře. Pokud má klíč, je vpuštěn dál, jinak se musí vrátit zpět
                        if(myPlayer.key == false) 
                        { 
                            oldDoorNotKey();
                        }
                        else
                        {
                            oldDoorKey();
                            myPlayer.state = true;
                        }
                        break;
                    case "md":
                        /*hráč si vybral moderní dveře.Dále je vpuštěn pouze pokud zadá kód a po vyřešení
                        hádanky získá klíč a může pokračovat*/
                        if (myPlayer.modernDoor == false)
                        {
                            modernDoor();
                            answer = Console.ReadLine();
                            if (answer == riddle1.solving)
                            {
                                correctCode();
                                riddle2.writeTask();

                                while (answer != riddle2.solving)
                                {
                                    Answer();
                                    answer = Console.ReadLine();
                                }
                                correctAnswerRiddle2();
                                myPlayer.key = true;
                                myPlayer.modernDoor = true;
                            }
                            else
                            {
                                wrongCode();
                            }
                        }
                        else
                        {
                            playerWereInModernDoor();
                        }
                        break;
                    case "ch":
                        /*hráč si vybral chodbu. Zobrazí se mu hádanka po jejímž vyřešení získá kód k
                        moderním dveřím*/
                        corridor();
                        riddle1.writeTask();
                        hallReturn = Console.ReadLine();
                        while(hallReturn != "h")
                        {
                            error();
                            hallReturn = Console.ReadLine();
                        }
                        break;
                    default:
                        //pokud hráč napsal cokoliv jiného než jednu ze tří možností, musí výběr opakovat
                        error();
                        break;
                }
            }

            /*Poté co hráč získal klíč ke starým dveřím je puštěn dál a nemůže se již vrátit. Má opět na výběr
             * dvě možnosti kam jít dál*/
            while (myPlayer.state == true)
            {
                if (myPlayer.hall == false)
                {
                    hall();
                    myPlayer.hall = true;
                }
                else
                {
                    hallAgain();
                }
                choice = Console.ReadLine();

                switch (choice) 
                {
                    case "l":
                        /*hráč si vybral levou chodbu a bude mít na výběr opět dvě možnosti. Osvětlenou
                        a tmavou chodbu*/
                        myPlayer.state = false;
                        leftCorridor();
                        while (myPlayer.state == false)
                        {
                            choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "s":
                                    /*pokud si hráč vybral osvětlenou chodbu, je vráceen do místnosti kde 
                                     měl na výběr mezi levou a pravou chodbou*/
                                    litCorridor();
                                    myPlayer.state = true;
                                    break;
                                case "t":
                                    /*pokud si hráč vybral tmavou chodpu, při prvním průchodu touto chodbou
                                     získá flétnu a část závěrečné hádanky. Při opakovaném průchodu se poze 
                                     vrátí do místnosti kde měl na výběr mezi levou a pravou chodbou.*/
                                    if (myPlayer.flute == false)
                                    {
                                        darkCorridor();
                                        myPlayer.flute = true;
                                    }
                                    else
                                    {
                                        darkCorridorReturn();
                                    }
                                    myPlayer.state = true;
                                    break;
                                default:
                                    //pokud hráč napsal cokoliv jiného než jednu ze dvou možností, musí výběr opakovat
                                    error();
                                    break;
                            }
                        }
                        break;
                    case "p": 
                        /*pokud si hráč vybral pravou chodbu a má flétnu, dostane hádanku a po jejím vyřešení část
                         poslední hádanky a posune se ve hře dál. Pokud flétnu nemá je okamžitě vrácen zpět.*/
                        if(myPlayer.flute == false)
                        {
                            rightCorridorWithoutFlute();
                        }
                        else
                        {
                            rightCorridorWithFlute();
                            riddle3.writeTask();

                            while (answer != riddle3.solving)
                            {
                                Answer();
                                answer = Console.ReadLine();
                            }
                            correctAnswerRiddle3();
                            myPlayer.state = false;
                        }
                        break;
                    default:
                        //pokud hráč napsal cokoliv jiného než jednu ze dvou možností, musí výběr opakovat
                        error();
                        break;
                }

            }

            /*hráč dostane čtvrtou hádanku a po jejím vyřešen dostane poslední část poslední hádanky a postoupí dál*/
            riddle4.writeTask();
            while (answer != riddle4.solving)
            {
                Answer();
                answer = Console.ReadLine();
            }
            correctAnswerRiddle4();

            /* Z postupně získaných částí hádanky hráč postaví poslední hádanku a když ji vyřeší hru úspěšně dokončil*/
            Riddle5();
            while (answer != riddle5.solving)
            {
                Answer();
                answer = Console.ReadLine();
            }
            end();
            Console.ReadKey();
        }
    }
}
