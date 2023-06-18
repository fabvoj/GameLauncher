-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hostiteľ: 127.0.0.1
-- Čas generovania: Sun 18.Jún 2023, 23:14
-- Verzia serveru: 10.4.27-MariaDB
-- Verzia PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáza: `eclipse`
--

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `games`
--

CREATE TABLE `games` (
  `game_id` int(12) NOT NULL,
  `game_name` varchar(50) NOT NULL,
  `game_price` varchar(25) NOT NULL,
  `game_picture` varchar(255) NOT NULL,
  `game_logo` varchar(255) NOT NULL,
  `game_cover` varchar(255) NOT NULL,
  `game_description` text NOT NULL,
  `game_genres` varchar(255) NOT NULL,
  `game_features` varchar(255) NOT NULL,
  `game_developer` varchar(255) NOT NULL,
  `game_publisher` varchar(255) NOT NULL,
  `game_release` varchar(24) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Sťahujem dáta pre tabuľku `games`
--

INSERT INTO `games` (`game_id`, `game_name`, `game_price`, `game_picture`, `game_logo`, `game_cover`, `game_description`, `game_genres`, `game_features`, `game_developer`, `game_publisher`, `game_release`) VALUES
(1, 'Grand Theft Auto V', '29,99€', 'gta_v.jpg', 'gta_v-logo.png', 'gta_v-cover.jpg', 'GRAND THEFT AUTO V\r\nWhen a young street hustler, a retired bank robber and a terrifying psychopath land themselves in trouble, they must pull off a series of dangerous heists to survive in a city in which they can trust nobody, least of all each other.\r\n\r\nGRAND THEFT AUTO ONLINE\r\nDiscover an ever-evolving world of choices and ways to play as you climb the criminal ranks of Los Santos and Blaine County in the ultimate shared Online experience.\r\n\r\nTHE CRIMINAL ENTERPRISE STARTER PACK\r\nThe Criminal Enterprise Starter Pack is the fastest way for new GTA Online players to jumpstart their criminal empires with the most exciting and popular content plus $1,000,000 bonus cash to spend in GTA Online - all content valued at over GTA $10,000,000 if purchased separately.', 'Action, Adventure', 'Competetive', 'Rockstar Games', 'Rockstar Games', '09/17/13'),
(2, 'Assassins Creed Odyssey', '59,99€', 'ac_odyssey.jpg', 'ac_odyssey-logo.png', 'ac_odyssey-cover.jpg', 'Assassin\'s Creed Odyssey\r\nFrom outcast to living legend, embark on an odyssey to uncover the secrets of your past and change the fate of Ancient Greece.\r\n\r\nTRAVEL TO ANCIENT GREECE\r\nFrom lush vibrant forests to volcanic islands and bustling cities, start a journey of exploration and encounters in a war torn world shaped by gods and men.\r\n\r\nFORGE YOUR LEGEND\r\nYour decisions will impact how your odyssey unfolds. Play through multiple endings thanks to the new dialogue system and the choices you make. Customize your gear, ship, and special abilities to become a legend.', 'Action, RPG, Stealth', 'Controller Support, Single Player', 'Ubisoft', 'Ubisoft', '10/02/18'),
(3, 'Assassins Creed® Valhalla', '59,99€', 'ac_valhalla.jpg', 'ac_valhalla-logo.png', 'ac_valhalla-cover.jpg', 'Become Eivor, a legendary Viking raider on a quest for glory.\r\n- Lead epic Viking raids against Saxon troops and fortresses.\r\n- Relive the visceral fighting style of the Vikings as you dual-wield powerful weapons.\r\n- Challenge yourself with the most varied collection of enemies ever in Assassin\'s Creed.\r\n- Shape the growth of your character and your clan\'s settlement with every choice you make.\r\n- Explore a Dark Age open world, from the harsh shores of Norway to the beautiful kingdoms of England.', 'Action, Open World, RPG, Stealth', 'Controller Support', 'Ubisoft Montreal', 'Ubisoft', '11/10/20'),
(4, 'Battlefield™ 2042', '59,99€', 'battlebug.jpg', 'battlebug-logo.png', 'battlebug-cover.jpg', 'Battlefield™ 2042 marks the return to the iconic all-out warfare of the franchise. Squad up and bring a cutting-edge arsenal into massive-scale battlegrounds, set in a near-future world transformed by disorder.', 'First Person, Shooter', 'Multiplayer', 'DICE', 'Electronic Arts', '10/06/21'),
(5, 'Bloons TD 6', '10,99€', 'bloons_td_6.jpg', 'bloons_td_6-logo.png', 'bloons_td_6-cover.png', 'Mega Popular Tower Defense\r\nCraft your perfect defense from a combination of powerful Monkey Towers and awesome Heroes, then pop every last invading Bloon!\r\nOver a decade of tower defense pedigree and regular massive updates makes Bloons TD 6 a favorite game for millions of players. Enjoy endless hours of strategy gaming with Bloons TD 6!', 'Strategy', 'Co-op, Multiplayer, Single Player', 'Ninja Kiwi', 'Ninja Kiwi', '06/14/18'),
(6, 'Hogwarts Legacy', '59,99€', 'bradavice.jpg', 'bradavice-logo.png', 'bradavice-cover.png', 'EXPLORE AN OPEN WORLD\r\nThe wizarding world awaits you. Freely roam Hogwarts, Hogsmeade, the Forbidden Forest, and the surrounding Overland area. \r\n\r\nBE THE WITCH OR WIZARD YOU WANT TO BE\r\nLearn spells, brew potions, grow plants, and tend to magical beasts along your journey. Get sorted into your house, forge relationships, and master skills to become the witch or wizard you want to be.\r\n\r\nEXPERIENCE A NEW WIZARDING WORLD STORY\r\nExperience the wizarding world in a forgotten era to uncover a hidden truth from its past. Battle against trolls, dark wizards, goblins, and more as you face a dangerous villain threatening the fate of the wizarding world.', 'Action, Adventure, RPG', 'Single Player', 'Avalanche Software', 'Warner Bros. Games', '02/10/23'),
(7, 'Cyberpunk 2077', '59,99€', 'cyberpunk_2077.jpg', 'cyberpunk_2077-logo.png', 'cyberpunk_2077-cover.jpg', 'Cyberpunk 2077 is an open-world, action-adventure RPG set in the megalopolis of Night City, where you play as a cyberpunk mercenary wrapped up in a do-or-die fight for survival. Improved and featuring all-new free additional content, customize your character and playstyle as you take on jobs, build a reputation, and unlock upgrades. The relationships you forge and the choices you make will shape the story and the world around you. Legends are made here. What will yours be?\r\n\r\nCREATE YOUR OWN CYBERPUNK\r\nBecome a cyberpunk, an urban mercenary equipped with cybernetic enhancements and build your legend on the streets of Night City.\r\n\r\nEXPLORE THE CITY OF THE FUTURE\r\nNight City is packed to the brim with things to do, places to see, and people to meet. And it’s up to you where to go, when to go, and how to get there.', 'Action, Adventure, Open World, RPG', 'Controller Support, Single Player', 'CD PROJEKT RED', 'CD PROJEKT RED', '12/10/20'),
(8, 'Days Gone', '49,99€', 'days_gone.jpg', 'days_gone-logo.png', 'days_gone-cover.jpg', 'Brutal open world action-adventure game.\r\nDays Gone is an open-world action-adventure game set in a harsh wilderness two years after a devastating global pandemic.\r\nStep into the dirt flecked shoes of former outlaw biker Deacon St. John, a bounty hunter trying to find a reason to live in a land surrounded by death. Scavenge through abandoned settlements for equipment to craft valuable items and weapons, or take your chances with other survivors trying to eke out a living through fair trade… or more violent means.', 'Action, Open World, Survival', 'Single Player', 'Bend Studio', 'PlayStation PC LLC', '05/18/21'),
(9, 'Dead Space', '59,99€', 'dead_space.jpg', 'dead_space-logo.png', 'dead_space-cover.png', 'Humanity Ends Here\r\n\r\nIsaac Clarke is an everyman engineer on a mission to repair the USG Ishimura, only to discover the ship\'s crew has been slaughtered and his beloved partner, Nicole, is lost somewhere on board.\r\nAlone and armed with only his engineering tools and skills, Isaac races to find Nicole as the nightmarish mystery of what happened aboard the Ishimura unravels around him. Trapped with hostile creatures, Isaac faces a battle for survival.\r\n\r\nIMMERSE YOURSELF IN NEXT-GEN SCI-FI HORROR\r\nA sci-fi horror classic returns fully rebuilt from the ground up with elevated visual fidelity and 3D atmospheric audio. From the frighteningly detailed rooms and workspaces of a slaughtered crew to the eerie atmospheric sounds of a desolate spaceship, you’ll explore a stunning sci-fi setting full of unpredictable and tense moments without interruption.', 'Action, Horror, Survival', 'Single Player', 'Motive Studio', 'Electronic Arts', '01/27/23'),
(10, 'DEATH STRANDING DIRECTORS CUT', '39,99€', 'death_stranding.jpg', 'death_stranding-logo.png', 'death_stranding-cover.jpg', 'From legendary game creator Hideo Kojima comes a genre-defying experience, now expanded in this definitive DIRECTOR’S CUT.\r\nIn the future, a mysterious event known as the Death Stranding has opened a doorway between the living and the dead, leading to grotesque creatures from the afterlife roaming the fallen world marred by a desolate society.\r\nAs Sam Bridges, your mission is to deliver hope to humanity by connecting the last survivors of a decimated America.\r\nCan you reunite the shattered world, one step at a time?', 'Action, Open World, Adventure', 'Controller Support, Single Player', 'KOJIMA PRODUCTIONS', '505 Games', '11/08/19'),
(11, 'Dying Light 2 Stay Human', '59.99€', 'dying_light_2.jpg', 'dying_light_2-logo.png', 'dying_light_2-cover.jpg', 'VAST OPEN WORLD\r\nParticipate in the life of a city engulfed in a new dark era. Discover different paths and hidden passages, as you explore its multiple levels and locations.\r\n\r\nCREATIVE & BRUTAL COMBAT\r\nTake advantage of your parkour skills to tip the scales of even the most brutal encounter. Clever thinking, traps and creative weapons will be your best friends.\r\n\r\nDAY AND NIGHT CYCLE\r\nWait for night to venture into dark hideouts of the Infected. Sunlight keeps them at bay, but once it’s gone, monsters begin the hunt, leaving their lairs free to explore.', 'Action, First Person, Horror, Open World, RPG, Survival', 'Co-op, Controller Support, Multiplayer, Single Player ', 'Techland', 'Techland', '02/04/22'),
(12, 'Far Cry® 6', '59,99€', 'far_cry_6.jpg', 'far_cry_6-logo.png', 'far_cry_6-cover.jpg', 'Welcome to Yara, a tropical paradise frozen in time. As the dictator of Yara, Antón Castillo is intent on restoring his nation to its former glory by any means necessary, with his son, Diego, following in his bloody footsteps. Their oppressive rule has ignited a revolution.\r\n- Play as Dani Rojas, a local Yaran, as you fight alongside a modern-day guerrilla revolution to liberate Yara. Play the full game solo or with a friend in co-op.\r\n- Explore jungles, beaches, and cities on foot, horseback, or in a wide variety of vehicles including boats and Jet Skis as you fight against Castillo’s regime in the most expansive Far Cry to date.\r\n- Feel the thrill of combat with an arsenal of hundreds of weapons alongside helpful amigos like Chorizo the dog and Guapo the gator.', 'Action, Adventure, Open World, Shooter', 'Co-op, Multiplayer, Single Player', 'Ubisoft Toronto', 'Ubisoft', '10/07/21'),
(13, 'God of War', '49,99€', 'god_of_war.jpg', 'god_of_war-logo.png', 'god_of_war-cover.jpg', 'Enter the Norse realm\r\nHis vengeance against the Gods of Olympus years behind him, Kratos now lives as a man in the realm of Norse Gods and monsters. It is in this harsh, unforgiving world that he must fight to survive… and teach his son to do the same.\r\n\r\nGrasp a second chance\r\nKratos is a father again. As mentor and protector to Atreus, a son determined to earn his respect, he is forced to deal with and control the rage that has long defined him while out in a very dangerous world with his son.\r\n\r\nJourney to a dark, elemental world of fearsome creatures\r\nFrom the marble and columns of ornate Olympus to the gritty forests, mountains and caves of pre-Viking Norse lore, this is a distinctly new realm with its own pantheon of creatures, monsters and gods.', 'Action, Adventure, RPG', 'Competetive, Single Player', 'Santa Monica Studio', 'PlayStation PC LLC', '04/20/18'),
(14, 'HITMAN World of Assassination', '69,99€', 'hitman_woa.jpg', 'hitman_woa-logo.png', 'hitman_woa-cover.jpg', 'Enter the world of the ultimate assassin.\r\n\r\nBECOME AGENT 47\r\nSuit up for a spy-thriller adventure where all your deadly abilities are put to the test across more than 20 locations.\r\n\r\nFREEDOM OF APPROACH\r\nYour deadliest weapon is creativity. Unlock new gear and up your game on highly replayable missions.\r\n\r\nWORLD OF ASSASSINATION\r\nTravel a living, breathing world, filled with intriguing characters and lethal opportunities.', 'Action, Stealth', 'Controller Support, Single Player', 'IO Interactive A/S', 'IO Interactive A/S', '01/20/21'),
(15, 'It Takes Two', '39,99€', 'it_takes_two.jpg', 'it_takes_two-logo.png', 'it_takes_two-cover.jpg', 'PURE CO-OP PERFECTION\r\nInvite a friend to join for free with Friend’s Pass*, and experience a thrilling adventure built purely for two. Choose from couch or online co-op with split-screen play, and face ever-changing challenges where working together is the only way forward.\r\n\r\nGLEEFULLY DISRUPTIVE GAMEPLAY\r\nFrom rampaging vacuum cleaners to suave love gurus – with It Takes Two, you never know what you’re up against next. Filled with genre-bending challenges and new character abilities to master in every level, you’ll experience a metaphorical merging of gameplay and narrative that pushes the boundaries of interactive storytelling.', 'Adventure, Platformer', 'Co-op, Controller Support', 'Hazelight', 'Electronic Arts', '03/25/21'),
(16, 'Kingdom Come: Deliverance', '29.99€', 'kingdom_come_deliverance.jpg', 'kingdom_come_deliverance-logo.png', 'kingdom_come_deliverance-cover.jpg', 'Thrust into a raging civil war, you watch helplessly as invaders storm your village and slaughter your family. Narrowly escaping the brutal attack, you grab your sword to fight back. Avenge the death of your parents and help repel the invading forces!\r\n\r\nMassive realistic open world\r\nMajestic castles, vast fields, all rendered in stunning high-end graphics.\r\n\r\nNon-linear story\r\nSolve quests in multiple ways, then face the consequences of your decisions.', 'Action, Adventure, Open World, RPG', 'Controller Support, Single Player', 'Warhorse Studios', 'Prime Matter', '02/13/18'),
(17, 'Rainbow Six Siege', '19,99€', 'kokotina.jpg', 'kokotina-logo.png', 'kokotina-cover.jpg', 'Tom Clancy\'s Rainbow Six® Siege is an elite, realistic, tactical, team-based shooter where superior planning and execution triumph. It features 5v5 attack vs. defense gameplay and intense close-quarters combat in destructible environments.\r\n\r\nChoose from over 60 operators, each with unique gadgets and customizable weapon loadouts. Outthink your opponents by breaching walls, floors, and windows, or lie in wait with deadly traps.\r\n\r\nIn Defense mode, coordinate with your team to transform your environments into impregnable strongholds. Fortify your positions, place traps, and create defensive systems to prevent the enemy team from breaching in. Then, hold your positions and ambush your opponent to ensure victory.\r\n\r\nIn Attack mode, observe the enemy positions and craft your cunning plan to breach in the enemy defenses, then execute your strategy by leading your team through narrow corridors, barricaded doorways, floors, windows, and reinforced walls. The right team can overcome any defense to win.', 'Action, Shooter, Strategy', 'Co-op, Competetive, Controller Support, Multiplayer', 'Ubisoft', 'Ubisoft', '12/1/15'),
(18, 'Need for Speed™ Unbound', '69,99€', 'nfs_unbound.jpg', 'nfs_unbound-logo.png', 'nfs_unbound-cover.jpg', 'TEAR UP THE STREETS, CONTROL THE CHASE.\r\nTear up the streets with friends as Need for Speed™ Unbound brings new ways to compare and compete with the squad in Lakeshore Online. Duck the cops to earn your way to dope new upgrades, and smash new events and Daily Challenges for the chance to gain XP, Bank, and new rides such as the luxurious Mercedes-Maybach S 680 2021, and hot new Custom Build, Lotus Emira Balmain Edition 2021.', 'Action, Racing', 'Controller Support, Multiplayer, Single Player', 'Criterion Games', 'Electronic Arts', '12/02/22'),
(19, 'The Last of Us™ Part I', '59,99€', 'posledny_z_nas.jpg', 'posledny_z_nas-logo.png', 'posledny_z_nas-cover.png', 'Experience the emotional storytelling and unforgettable characters in The Last of Us™, winner of over 200 Game of the Year awards.\r\nIn a ravaged civilization, where infected and hardened survivors run rampant, Joel, a weary protagonist, is hired to smuggle 14-year-old Ellie out of a military quarantine zone. However, what starts as a small job soon transforms into a brutal cross-country journey.', 'Action, Adventure', 'Single Player', 'Naughty Dog LLC', 'PlayStation PC LLC', '03/28/23'),
(20, 'Red Dead Redemption 2', '59,99€', 'rdr_2.jpg', 'rdr_2-logo.png', 'rdr_2-cover.jpg', 'America, 1899. Arthur Morgan and the Van der Linde gang are outlaws on the run. With federal agents and the best bounty hunters in the nation massing on their heels, the gang must rob, steal and fight their way across the rugged heartland of America in order to survive. As deepening internal divisions threaten to tear the gang apart, Arthur must make a choice between his own ideals and loyalty to the gang who raised him.\r\nRed Dead Redemption 2 also includes the shared living world of Red Dead Online – forge your own path as you battle lawmen, outlaw gangs and ferocious wild animals to build a life on the American frontier. Build a camp, ride solo or form a posse and explore everything from the snowy mountains in the North to the swamps of the South, from remote outposts to busy farms and bustling towns. Chase down bounties, hunt, fish and trade, search for exotic treasures, run your own underground Moonshine distillery, or become a Naturalist to learn the secrets of the animal kingdom and much more in a world of astounding depth and detail – includes all new features, gameplay content and additional enhancements released since launch.', 'Action, Narration, Open World', 'Single Player', 'Rockstar Games', 'Rockstar Games', '11/05/19'),
(21, 'Sifu', '39,99€', 'sifu.jpg', 'sifu-logo.png', 'sifu-cover.jpg', 'Is one life enough to know Kung Fu?\r\nWhether you choose to play as a male or a female character, in Sifu, you will ponder that question on your path for revenge, hunting down your family’s assassins. One against all, you have no allies, countless enemies, and a mysterious amulet to bring you back to life every time you die. Yet, be warned! Your secret weapon comes with a hefty price to pay: aging and its consequences.\r\n\r\nLearning by fire\r\nYour enemies don’t wait their turn, and they don’t broadcast their intent. Dodge, parry, strike, use combos and be like water making its way through captivating environments. Learn how to master your art, whether by fighting through the underbelly of a nightclub, scrambling through a refined gallery to avoid getting surrounded, or\r\nvertically navigating a towering office building.', 'Action, Fighting, Indie', 'Controller Support, Single Player', 'Sloclap', 'Sloclap', '02/08/22'),
(22, 'Marvels Spider-Man: Miles Morales', '49,99€', 'spider-man_mm.jpg', 'spider-man_mm-logo.png', 'spider-man_mm-cover.jpg', 'The Rise of Miles Morales\r\nMiles Morales discovers explosive powers that set him apart from his mentor, Peter Parker. Master his unique, bio-electric venom blast attacks and covert camouflage power alongside spectacular web-slinging acrobatics, gadgets and skills.\r\n\r\nA War for Power\r\nA war for control of Marvel’s New York has broken out between a devious energy corporation and a high-tech criminal army. With his new home at the heart of the battle, Miles must learn the cost of becoming a hero and decide what he must sacrifice for the greater good.', 'Action, Open World', 'Controller Support, Single Player', 'Insomniac Games, Nixxes Software', 'PlayStation PC LLC', '11/18/22'),
(23, 'Marvels Spider-Man Remastered', '59,99€', 'spider-man_remastered.jpg', 'spider-man_remastered-logo.png', 'spider-man_remastered-cover.jpg', 'Be Greater\r\nWhen iconic Marvel villains threaten Marvel’s New York, Peter Parker and Spider-Man’s worlds collide. To save the city and those he loves, he must rise up and be greater.\r\n\r\nFeel like Spider-Man\r\nAfter eight years behind the mask, Peter Parker is a crime-fighting master. Feel the full power of a more experienced Spider-Man with improvisational combat, dynamic acrobatics, fluid urban traversal and environmental interactions.', 'Action, Adventure', 'Controller Support, Single Player', 'Insomniac Games, Nixxes Software', 'PlayStation PC LLC', '08/12/22'),
(24, 'Tomb Raider GOTY', '19,99€', 'tomb_raider.jpg', 'tomb_raider-logo.png', 'tomb_raider-cover.jpg', 'Tomb Raider is a critically acclaimed action adventure that explores the intense and gritty origin story of Lara Croft and her ascent from a young woman to a hardened survivor. Armed only with raw instincts and the ability to push beyond the limits of human endurance, Lara must fight to unravel the dark history of a forgotten island to escape its relentless hold. The Game of the Year edition includes the Tomb of the Lost Adventurer, 6 single player outfits for Lara and 4 characters.', 'Action, Adventure', 'Controller Support, Single Player', 'Crystal Dynamics', 'Square Enix', '03/05/13');

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `userinfo`
--

CREATE TABLE `userinfo` (
  `user_id` int(255) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Birthday` varchar(12) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `DateCreated` varchar(50) NOT NULL DEFAULT current_timestamp(),
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Sťahujem dáta pre tabuľku `userinfo`
--

INSERT INTO `userinfo` (`user_id`, `FirstName`, `LastName`, `Gender`, `Birthday`, `Email`, `Username`, `Password`, `DateCreated`, `LastLogin`) VALUES
(2, 'fabian', 'nemcok', 'Male', '23. 1. 2006', 'admin420@spsit.sk', 'fabnixx', 'cadcaontop', '2023-05-24 23:14:15', '25. 5. 2023 9:18:59'),
(4, 'Patrik', 'Nemčok', 'Male', '23. 1. 2001 ', 'patkonemcok@gmail.com', 'TW_PatoN', 'konecnetoide', '2023-06-03 19:27:58', '25. 5. 2023 9:18:59'),
(5, 'Fabián', 'Vojár', 'Male', '27. 1. 2006 ', 'fabvoj@gmail.com', 'fabvoj', 'Jebemkaleradoriti', '2023-06-06 07:38:16', '25. 5. 2023 9:18:59'),
(6, 'Fabian', 'Vojar', 'Mental Disorder', '31. 1. 2001 ', 'zjedzmikar@gmail.com', 'fabvojjesuper', 'Somsuper', '2023-06-08 09:33:23', '25. 5. 2023 9:18:59'),
(7, 'Amater', 'Jozeg', 'Male', '', 'test@guna.sk', '', '123', '2023-06-17 10:09:39', '25. 5. 2023 9:18:59');

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `user_games`
--

CREATE TABLE `user_games` (
  `user_id` int(11) NOT NULL,
  `game_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Sťahujem dáta pre tabuľku `user_games`
--

INSERT INTO `user_games` (`user_id`, `game_id`) VALUES
(2, 1),
(7, 1),
(7, 2),
(7, 3),
(7, 4),
(7, 5);

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `verifycodes`
--

CREATE TABLE `verifycodes` (
  `id` int(11) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Code` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Kľúče pre exportované tabuľky
--

--
-- Indexy pre tabuľku `games`
--
ALTER TABLE `games`
  ADD PRIMARY KEY (`game_id`);

--
-- Indexy pre tabuľku `userinfo`
--
ALTER TABLE `userinfo`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexy pre tabuľku `user_games`
--
ALTER TABLE `user_games`
  ADD PRIMARY KEY (`user_id`,`game_id`),
  ADD KEY `game_id` (`game_id`);

--
-- Indexy pre tabuľku `verifycodes`
--
ALTER TABLE `verifycodes`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pre exportované tabuľky
--

--
-- AUTO_INCREMENT pre tabuľku `games`
--
ALTER TABLE `games`
  MODIFY `game_id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT pre tabuľku `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `user_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pre tabuľku `verifycodes`
--
ALTER TABLE `verifycodes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Obmedzenie pre exportované tabuľky
--

--
-- Obmedzenie pre tabuľku `user_games`
--
ALTER TABLE `user_games`
  ADD CONSTRAINT `user_games_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `userinfo` (`user_id`),
  ADD CONSTRAINT `user_games_ibfk_2` FOREIGN KEY (`game_id`) REFERENCES `games` (`game_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
