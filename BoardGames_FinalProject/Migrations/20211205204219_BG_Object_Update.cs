using Microsoft.EntityFrameworkCore.Migrations;

namespace BoardGames_FinalProject.Migrations
{
    public partial class BG_Object_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "price",
                table: "BoardGames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "BoardGames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "BoardGames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "price_ca",
                table: "BoardGames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "3IPVIROfvl",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p><em><strong>Brass: Birmingham</strong></em> is an economic strategy game sequel to Martin Wallace's 2007 masterpiece, <em>Brass</em>. <em>Birmingham</em> tells the story of competing entrepreneurs in Birmingham during the industrial revolution, between the years of 1770-1870.</p>\r\n<p>As in its predecessor, you must develop, build, and establish your industries and network, in an effort to exploit low or high market demands.</p>\r\n<p>Each round, players take turns according to the turn order track, receiving two actions to perform any of the following actions (found in the original game):</p>\r\n<p>1) <strong>Build</strong> - Pay required resources and place an industry tile.<br />2) <strong>Network</strong> - Add a rail/canal link, expanding your network.<br />3) <strong>Develop</strong> - Increase the VP value of an industry.<br />4) <strong>Sell</strong> - Sell your cotton, manufactured goods and pottery.<br />5) <strong>Loan</strong> - Take a £30 loan and reduce your income.</p>\r\n<p><em>Brass: Birmingham</em> also features a new sixth action:</p>\r\n<p>6) <strong>Scout</strong> - Discard three cards and take a wild location and wild industry card. (This action replaces Double Action Build in original <em>Brass</em>.)</p>\r\n<p>The game is played over two halves: the canal era (years 1770-1830) and the rail era (years 1830-1870). To win the game, score the most VPs. VPs are counted at the end of each half for the canals, rails and established (flipped) industry tiles.</p>\r\n<p><em>Birmingham</em> features dynamic scoring canals/rails. Instead of each flipped industry tile giving a static 1 VP to all connected canals and rails, many industries give 0 or even 2 VPs. This provides players with the opportunity to score much higher value canals in the first era, and creates interesting strategy with industry placement.</p>\r\n<p>Iron, coal, and cotton are three industries which appear in both the original <em>Brass</em> as well as in <em>Brass: Birmingham</em>.</p>\r\n<p><strong>New &quot;Sell&quot; system</strong></p>\r\n<p>Brewing has become a fundamental part of the culture in Birmingham. You must now sell your product through traders located around the edges of the board. Each of these traders is looking for a specific type of good each game. To sell cotton, pottery, or manufactured goods to these traders, you must also &quot;grease the wheels of industry&quot; by consuming beer. For example, a level 1 cotton mill requires one beer to flip. As an incentive to sell early, the first player to sell to a trader receives free beer.</p>\r\n<p><em>Birmingham</em> features three all-new industry types:</p>\r\n<p><strong>Brewery</strong> - Produces precious beer barrels required to sell goods.</p>\r\n<p><strong>Manufactured goods</strong> - Function like cotton, but features eight levels. Each level of manufactured goods provides unique rewards, rather than just escalating in VPs, making it a more versatile (yet potentially more difficult) path vs cotton.</p>\r\n<p><strong>Pottery</strong> - These behemoths of Birmingham offer huge VPs, but at a huge cost and need to plan.</p>\r\n<p><strong>Increased Coal and Iron Market size</strong> - The price of coal and iron can now go up to £8 per cube, and it's not uncommon.</p>\r\n<p><em>Brass: Birmingham</em> is a sequel to Brass. It offers a very different story arc and experience from its predecessor.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629324669399.png", "87.95" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "5H5JS0KLzK",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p><em><strong>Wingspan</strong></em> is a competitive, medium-weight, card-driven, engine-building board game from Stonemaier Games.</p>\r\n<p>You are bird enthusiasts—researchers, bird watchers, ornithologists, and collectors—seeking to discover and attract the best birds to your aviary. Each bird extends a chain of powerful combinations in one of your habitats (actions). These habitats focus on several key aspects of growth:</p>\r\n<ul>\r\n<li>Gain food tokens via custom dice in a birdfeeder dice tower</li>\r\n<li>Lay eggs using egg miniatures in a variety of colors</li>\r\n<li>Draw from hundreds of unique bird cards and play them</li>\r\n</ul>\r\n<p>The winner is the player with the most points after 4 rounds.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629325193747.png", "54.99" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "6FmFeux5xH",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>After five years of Pandemic, hundreds of thousands of players have contracted the virus! To celebrate this milestone, Pandemic has been completely re-designed. With new artwork by Chris Quilliams (Clash of Cultures, Merchants &amp; Marauders), Pandemic will now have a more modern look, inside and outside the box. With two new characters (the Contingency Planner and the Quarantine Specialist) face the game in ways you never thought possible as brand-new, virulent challenges await you!</p>\r\n<p>In <em><strong>Pandemic</strong></em>, several virulent diseases have broken out simultaneously all over the world! The players are disease-fighting specialists whose mission is to treat disease hotspots while researching cures for each of four plagues before they get out of hand.</p>\r\n<p>The game board depicts several major population centers on Earth. On each turn, a player can use up to four actions to travel between cities, treat infected populaces, discover a cure, or build a research station. A deck of cards provides the players with these abilities, but sprinkled throughout this deck are <em>Epidemic!</em> cards that accelerate and intensify the diseases' activity. A second, separate deck of cards controls the &quot;normal&quot; spread of the infections.</p>\r\n<p>Taking a unique role within the team, players must plan their strategy to mesh with their specialists' strengths in order to conquer the diseases. For example, the Operations Expert can build research stations which are needed to find cures for the diseases and which allow for greater mobility between cities; the Scientist needs only four cards of a particular disease to cure it instead of the normal five—but the diseases are spreading quickly and time is running out. If one or more diseases spreads beyond recovery or if too much time elapses, the players all lose. If they cure the four diseases, they all win!</p>\r\n<p>The 2013 edition of <em>Pandemic</em> includes two new characters—the Contingency Planner and the Quarantine Specialist—not available in earlier editions of the game.</p>\r\n<h4>Artists:</h4>\r\n<p>Joshua Cappel (graphics and illustration)</p>\r\n<p>Régis Moulun (cover painting)</p>\r\n<p>Chris Quilliams (2013 edition)<br /><br /><br /></p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1559254186140-51iNoyxoamL.jpg", "40.99" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "7NYbgH2Z2I",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>Viticulture is a worker-placement game set in the foothills of Tuscany. The Essential Edition includes the second edition of Viticulture along with several elements from the original Tuscany expansion pack, hand-picked by famed designer Uwe Rosenberg.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629323034692.jpg", "49.17" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "8xos44jY7Q",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>Within the charming valley of Everdell, beneath the boughs of towering trees, among meandering streams and mossy hollows, a civilization of forest critters is thriving and expanding. From Everfrost to Bellsong, many a year have come and gone, but the time has come for new territories to be settled and new cities established. You will be the leader of a group of critters intent on just such a task. There are buildings to construct, lively characters to meet, events to host - you have a busy year ahead of yourself. Will the sun shine brightest on your city before the winter moon rises? <br /><br />Everdell is a game of dynamic tableau building and worker placement.<br /><br />On their turn a player can take one of three actions:<br />a) Place a Worker: Each player has a collection of Worker pieces. These are placed on the board locations, events, and on Destination cards. Workers perform various actions to further the development of a player's tableau: gathering resources, drawing cards, and taking other special actions.<br />b) Play a Card: Each player is building and populating a city; a tableau of up to 15 Construction and Critter cards. There are five types of cards: Travelers, Production, Destination, Governance, and Prosperity. Cards generate resources (twigs, resin, pebbles, and berries), grant abilities, and ultimately score points. The interactions of the cards reveal numerous strategies and a near infinite variety of working cities.<br />c) Prepare for the next Season: Workers are returned to the players supply and new workers are added. The game is played from Winter through to the onset of the following winter, at which point the player with the city with the most points wins.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1574877074147", "61.95" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "9iBOPn3lES",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>Patchwork is a form of needlework that involves sewing together pieces of fabric into a larger design. In the past, it was a way to make use of leftover pieces of cloth to create clothing and quilts. Today, patchwork is a form of art, in which the designers use precious fabrics to create beautiful textiles. The use of uneven pieces of fabric in particular can result in real masterpieces and is therefore being practiced by a large number of textile artists.<br /><br />To create a beautiful quilt, however, requires effort and time, but the available patches just do not want to fit together. So choose your patches carefully and keep a healthy supply of buttons to not only finish your quilt, but to make it better and more beautiful than your opponent's.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629323010323.jpg", "23.79" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "AuBvbISHR6",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p><strong>Ticket to Ride</strong> is a cross-country train adventure game. Players collect train cards that enable them to claim railway routes connecting cities throughout North America. The longer the routes, the more points they earn. Additional points come to those who can fulfill their Destination Tickets by connecting two distant cities, and to the player who builds the longest continuous railway. So climb aboard for some railroading fun and adventure. You've got a Ticket to Ride!<br /><br />October 2, 1900 -- it's 28 years to the day that noted London eccentric, Phileas Fogg accepted and then won a 20,000 bet that he could travel Around the World in 80 Days. Now at the dawn of the century some old friends have gathered to celebrate Fogg's impetuous and lucrative gamble -- and to propose a new wager of their own. The stakes: $1 million in a winner-takes-all competition. The objective: to see the most cities in North America -- in just 7 days. <br /><br />-Spiel Des Jahres 2004(German game of the year)<br />-As d'Or Cannes 2004 (French game of the year)<br />-Game of the year 2004 - Japan<br />-Game of the year 2004 - Sweden<br />-Game of the year 2004 - Finland<br />-Diana Jones Excellence in Gaming Award 2004<br />-Origins Award Winner - Best Board Game 2005<br />-Game of the year 2004 - Spain<br />-Parent's Choice Foundation Silver Medal 2004</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629324738308.jpg", "41.97" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "E4ELA8cG85",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>In Race for the Galaxy from Rio Grande Games, players build galactic civilizations using game cards that represent worlds or technical and social developments. Each round consists of one or more of five possible phases. In each round, each player secretly and simultaneously chooses one of seven different action cards and then reveals it. Only the selected phases occur. For these phases, every player performs the phasea€s action, while the selecting player(s) also get a bonus for that phase. For example, if at least one player chooses the Develop action, then the Develop phase will occur, otherwise it is skipped. In it, each player may simultaneously select a development from his hand of cards to build. After revealing the cards, each player adds his development to his tableau of cards on the table and then discards cards from his hand equal to its cost. Each player who chose Develop discards one card fewer as his bonus. Explore allows a player to draw cards and select which of them to add to his hand. Settle allows a player to place a world in his tableau. Some worlds produce goods, represented by face down cards, when Produce is selected. These goods can be discarded for victory points or sold to add cards to the player's hand by selecting Consume. With cards, players can settle new worlds and build more developments, gaining both victory points and card powers that provide advantages in certain phases. The player who best manages his cards, phase and bonus selections, and card powers to build the greatest space empire, wins. The winner is the player with the most victory points.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629322825257.png", "30.07" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "FCuXPSfhDR",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>2,000 years ago, the Roman Empire ruled the lands around the Mediterranean Sea. With peace at the borders, harmony inside the provinces, uniform law, and a common currency, the economy thrived and gave rise to mighty Roman dynasties as they expanded throughout the numerous cities. Guide one of these dynasties and send colonists to the remote realms of the Empire, develop your trade network, and appease the ancient gods to curry their favor - all to gain the chance to emerge victorious in Concordia.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629323022645.jpg", "54.90" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "fDn9rQjH9O",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level and the ocean coverage until the environment is habitable. In Terraforming Mars you play one of those corporations and work together in the terraforming process, but compete in doing the best work, with victory points awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar systems and other commendable achievements. The players acquire unique project cards, which represent anything from introducing plant life or animals, hurling asteroids at the surface, building cities, and establishing greenhouse gas industries to heat up the atmosphere. You compete for the best places for your city tiles, ocean tiles and greenery tiles. When the terraforming process is complete, the player corporation with the most victory points wins.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629324032557.jpg", "54.97" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "GP7Y2xOUzj",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>The two rival spymasters know the secret identities of 25 agents. Their teammates know the agents only by their CODENAMES.<br /><br />The teams compete to see who can make contact with all of their agents first. Spymasters give one-word clues that can point to multiple words on the board. Their teammates try to guess words of the right color while avoiding those that belong to the opposing team. And everyone wants to avoid the assassin.<br /><br />Codenames: win or lose, it's fun to figure out the clues.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1559254183526-51f6ysXCMmL.jpg", "16.95" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "i5Oqu5VZgP",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p><strong>Azul</strong> was designed by the world famous, award-winning game author Michael Riesling. Azul captures the beautiful aesthetics of Moorish art in a contemporary board game.</p>\r\n<p>Players compete as artisans decorating the walls of the royal Palace of Dvora. By carefully drafting the correct Quantity and style of tiles, the most clever of artisans plan ahead to maximize the beauty of their work (not to mention their scores!) while ensuring they wasted no supplies in the process.</p>\r\n<p>Introduced by the moors, &quot;azulejos&quot; (originally white and blue ceramic tiles) were fully embraced by the Portuguese, when their King Manuel I, on a visit to the Alhambra Palace in Southern Spain, was mesmerized by the stunning beauty of the Moorish decorative tiles. The King, awestruck by the interior beauty of the Alhambra, immediately ordered that his own Palace in Portugal be decorated with similar wall tiles.</p>\r\n<p>As a tile-laying artist, you have been challenged to embellish the walls of the royal Palace of Dvora.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1559254200327-61EFZADvURL.jpg", "33.99" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "j8LdPFmePE",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p><strong>7 Wonders Duel</strong> is a fast-paced, two-player edition of Antoine Bauza's award-winning civilization-building game.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629323024736.jpg", "30.99" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "kPDxpJZ8PD",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>Powerful Spirits have existed on this isolated island for time immemorial. They are both part of the natural world and - at the same time - something beyond nature. Native Islanders, known as the Dahan, have learned how to co-exist with the spirits, but with a healthy dose of fear and reverence. However, now, the island has been &quot;discovered&quot; by invaders from a far-off land. These would-be colonists are taking over the land and upsetting the natural balance, destroying the presence of Spirits as they go. As Spirits, you must grow in power and work together to drive the invaders from your island... before it's too late!</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1559254941010-61PJxjjnbfL.jpg", "73.95" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "M7r9tO1GbX",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>Welcome to Quedlinburg, where the best quack doctors gather to brew potions to cure smelly feet, homesickness, and hiccups. You're one of them. Your challenge is to make a special brew that will make you the best miracle doctor in the land.</p>\r\n<p><em>The Quacks of Quedlinburg</em> is a fun, quick push-your-luck game where you draw from your stock of ingredients, adding them to your cauldron, until your brew seems just right. But be careful: add the wrong ingredient and the potion could spoil. Do you stop early to raise your chance of making a better potion later, or risk a setback to reach for more money and fame now? Finding the right balance between risk and reward is key.</p>\r\n<p><strong>Winner of the 2018 Gamer</strong><strong>'s Game of the Year in Germany </strong><strong>(the Kennerspiel des Jahres - considered the Oscar of boardgames)</strong></p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1627565358705", "62.95" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "mce5HZPnF5",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>The world is on the brink of disaster. In Pandemic Legacy, your disease-fighting team must keep four deadly diseases at bay for a whole year. Each month will bring new surprises, and your actions in each game will have repercussions on the next. Will you let cities fall to the diseases? Will your team be enough to keep the viruses at bay for a whole year? Craft your own unique Pandemic experience with Pandemic Legacy.</p>\r\n<p><strong>Pandemic Legacy</strong> is a co-operative campaign game, with an overarching story-arc played through 12-24 sessions, depending on how well your group does at the game. At the beginning, the game starts very similar to basic <em><a href=\"https://boardgamegeek.com/boardgame/30549/pandemic\">Pandemic</a></em>, in which your team of disease-fighting specialists races against the clock to travel around the world, treating disease hotspots while researching cures for each of four plagues before they get out of hand.</p>\r\n<p>During a player's turn, they have four actions available, with which they may travel around in the world in various ways (sometimes needing to discard a card), build structures like research stations, treat diseases (removing one cube from the board; if all cubes of a color have been removed, the disease has been eradicated), trade cards with other players, or find a cure for a disease (requiring five cards of the same color to be discarded while at a research station). Each player has a unique role with special abilities to help them at these actions.</p>\r\n<p>After a player has taken their actions, they draw two cards. These cards can include epidemic cards, which will place new disease cubes on the board, and can lead to an outbreak, spreading disease cubes even further. Outbreaks additionally increase the panic level of a city, making that city more expensive to travel to.</p>\r\n<p>Each month in the game, you have two chances to achieve that month's objectives. If you succeed, you win and immediately move on to the next month. If you fail, you have a second chance, with more funding for beneficial event cards.</p>\r\n<p>During the campaign, new rules and components will be introduced. These will sometimes require you to permanently alter the components of the game; this includes writing on cards, ripping up cards, and placing permanent stickers on components. Your characters can gain new skills, or detrimental effects. A character can even be lost entirely, at which point it's no longer available for play.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1559257833516-612BUfjuA7fL.jpg", "57.99" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "O0G8z5Wgz1",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>As a wealthy Renaissance merchant, acquire mines and transportation, hire artisans and woo the nobility. Create the most fantastic jewelry to become the best-known merchant of them all! Acquire precious stones to trade them for development cards. Use development cards to acquire more gem stones. Use your gems and gold to create the most fantastic jewelry, and appeal to the nobles to gain the prestige you need to win.<br /><br />Splendor is a fast-paced and addictive game of chip-collecting and card development. Players are merchants of the Renaissance trying to buy gem mines, means of transportation, shops; all in order to acquire the most prestige points. If you're wealthy enough, you might even receive a visit from a noble at some point, which of course will further increase your prestige.<br /><br />On your turn, you may (1) collect chips (gems), or (2) buy and build a card, or (3) reserve one card. If you collect chips, you take either three different kinds of chips or two chips of the same kind. If you buy a card, you pay its price in chips and add it to your playing area. To reserve a card, you place it in front of you face down for later building; this costs you a round, but you also get gold in the form of a joker chip, which you can use as any gem.<br /><br />All of the cards you buy increase your wealth as they give you a permanent gem bonus for later buys; some of the cards also give you prestige points. In order to win the game, you must reach 15 prestige points before your opponents do.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1559254164722-51AHDwGznvL.jpg", "39.95" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "OF145SrX44",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>You are the leader of one of the 7 great cities of the Ancient World. Gather resources, develop commercial routes and affirm your military supremacy. Build your city and erect an architectural wonder which will transcend future times!<br /><br /><strong> 7 Wonders</strong> is a simple and addictive game for the whole family. In 30 minutes you can raise a complete civilization and build the greatest Wonders of the World.</p>\r\n<p><em>Winner of the 2011 Kennerspiel des Jahres (Enthusiasts Game of the Year) Award.</em></p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1559253945470-61dlm9QcXpL.jpg", "94.55" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "oGVgRSAKwX",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>Each game of <em>Carcassonne</em> reveals a unique environment as tiles form a landscape of cities, roads, fields, and monasteries. Claim these features with your followers to win the game.</p>\r\n<p><em>Carcassonne</em> is a tile placement game where players collectively construct the area around the medieval French city of Carcassonne while competing to place followers on various features and score the most points.</p>\r\n<p>First published in 2000, the game's accessible yet deep design has attracted a wide fan base and led to the development of numerous expansions (eg Rivers) and standalone titles in the <em>Carcassonne</em> line.</p>", "https://cdn.shopify.com/s/files/1/0513/4077/1515/products/carcassonne-board-game.jpg?v=1609629064", "33.95" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "OIXt3DmJU0",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p>The women and men of your expedition build the first two settlements. Fortunately, the land is rich in natural resources. You build roads and new settlements that eventually become cities. Will you succeed in gaining supremacy on Catan? Barter trade dominates the scene. Some resources you have in abundance, other resources are scarce. Ore for wool, brick for lumber - you trade according to what is needed for your current building projects. Proceed strategically! If you found your settlements in the right places and skillfully trade your resources, then the odds will be in your favor. But your opponents are smart too.</p>\r\n<p>To begin the game, we build the game board using hexagonal terrain tiles. Catan is born - a beautiful island with mountains, pastures, hills, fields, and forests, surrounded by the sea.</p>\r\n<p>Each of us places two small houses on spaces where three terrain hexes meet. They are our starting settlements.</p>\r\n<p>And so it begins. I roll two dice. An “11”! Each terrain hex is marked with a die roll number. Each player who owns a settlement adjacent to a terrain hex marked with the number rolled receives a resource produced by this hex. Hills produce brick, forests produce lumber, mountains produce ore, fields produce grain, and pastures produce wool.</p>\r\n<p>We use these resources to expand across Catan: we build roads and new settlements, or we upgrade our existing settlements to cities. For example, a road costs 1 brick and 1 lumber. If we do not have the necessary resources, we can acquire them by trading with our opponents.</p>\r\n<p>Each settlement is worth 1 victory point and each city is worth 2 victory points. If you expand cleverly, you may be the first player to reach 10 victory points and thus win the game!</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629324722072.jpg", "36.97" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "RLlDWHh7hR",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p><strong>Gloomhaven</strong> is a game of Euro-inspired tactical combat in a persistent world of shifting motives. Players will take on the role of a wandering adventurer with their own special set of skills and their own reasons for traveling to this dark corner of the world.<br /><br />Players must work together out of necessity to clear out menacing dungeons and forgotten ruins. In the process they will enhance their abilities with experience and loot, discover new locations to explore and plunder, and expand an ever-branching story fueled by the decisions they make.<br /><br />This is a legacy game with a persistent and changing world that is ideally played over many game sessions. After a scenario, players will make decisions on what to do, which will determine how the story continues, kind of like a &quot;Choose Your Own Adventure&quot; book. Playing through a scenario is a cooperative affair where players will fight against automated monsters using an innovative card system to determine the order of play and what a player does on their turn.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1559254920151-51ulRXlJ7LL.jpg", "112.47" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "TAAifFP590",
                columns: new[] { "description", "image_url", "price", "price_ca" },
                values: new object[] { "<p>Find adventure in this marvelous asymmetric game. Root provides limitless replay value as you and your friends explore the unique factions all wanting to rule a fantastic forest kingdom. Play as the Marquise de Cat and dominate the woods, extracting its riches and policing its inhabitants, as the Woodland Alliance, gathering supporters and coordinate revolts against the ruling regime, the Eyrie Dynasties, regaining control of the woods while keeping your squabbling court at bay, or as the Vagabond, seeking fame and fortune as you forge alliances and rivalries with the other players. Each faction has its own play style and paths to victory, providing an immersive game experience you will want to play again and again.</p>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1629324760985.jpg", "59.99", "59.95" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "VibNUMwsqr",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<div>\r\n<p>Welcome to the world of <em><strong>Santorini</strong></em>, a fantastic reimagining of the classic abstract game from 2004. Players are given a sandbox in which to play as gods, moving their workers around the board to build up a beautiful, multi-tiered city. Do you have what it takes to outsmart your opponents? Find out, in <em>Santorini</em>!</p>\r\n<div>\r\n<div>\r\n<p><em><strong>Santorini</strong></em> is a re-imagining of the purely abstract 2004 edition. Since its original inception over 30 years ago, Santorini has been continually developed, enhanced and refined by designer Gordon Hamilton.</p>\r\n<p>Santorini is an accessible strategy game, simple enough for an elementary school classroom while aiming to provide gameplay depth and content for hardcore gamers to explore, The rules are simple. Each turn consists of 2 steps:</p>\r\n<p><strong>1. Move</strong> - move one of your builders into a neighboring space. You may move your Builder Pawn on the same level, step-up one level, or step down any number of levels.</p>\r\n<p><strong>2. Build</strong> - Then construct a building level adjacent to the builder you moved. When building on top of the third level, place a dome instead, removing that space from play.</p>\r\n<p><strong>Winning the game</strong> - If either of your builders reaches the third level, you win.</p>\r\n<p><strong>Variable player powers</strong> - Santorini features variable player powers layered over an otherwise abstract game, with 40 thematic god and hero powers that fundamentally change the way the game is played.</p>\r\n</div>\r\n</div>\r\n<p><br /><br />Turns in <em>Santorini</em> are made up of two simple step: Move and Build. Move around the board and build a building in a spot adjacent to one of your workers. The first player to move their worker from a second level building to a third level building wins the game! Though, there are a few things that add a wrinkle to the basic formula.<br /><br />Invoke the Power of the gods!<br />Each player will have access to a god power which lets them do things a little differently than normal. Be it changing the rules for how you can build or move, changing how you interact with other players, or providing you with an alternate victory condition, the 30 different god powers are sure to make every game of <em>Santorini</em> different and exciting!</p>\r\n</div>", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1577065005762", "37.36" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "VNBC6yq1WO",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "15th century princes from the Loire Valley devote their efforts to strategic trading and building in order to bring their estates to prosperity and prominence. Over the course of 5 rounds, collect the most points by trading, live stock farming, city building and scientific research to win!<br />\r\n<br />\r\nThe Hundred Years? war is over and the Renaissance is looming. Conditions are perfect for the princes of the Loire Valley to propel their estates to prosperity and prominence. Through strategic trading and building, clever planning, and careful thought, players add settlements and castles, practice trade along the river, exploit silver mines, farm livestock, and more in this classic Stefan Feld Eurogame.<br />\r\n<br />\r\nHow to Play: 1. Players take turns rolling two dice and choosing to move goods tiles from the game board to their player boards; from their player boards onto corresponding numbered and colored regions of their playing fields; to deliver goods in exchange for silverlings; or to take worker tiles. 2. Play continues, with players completing additional actions and noting victory points for each tile placed. 3. Five turns are taken per round, with additional victory points awarded for unused money and workers, undelivered goods, and percentage of settlement complete. The player with the most victory points after five rounds wins the game.", "https://s3-us-west-1.amazonaws.com/5cc.images/games/uploaded/1559254202422-51mP2aJfyxL.jpg", "156.09" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "yqR4PtpO8X",
                columns: new[] { "description", "image_url", "price_ca" },
                values: new object[] { "<p><em>Scythe</em> gives players almost complete control over their fate. Other than each player's individual hidden objective card, the only elements of luck or variability are &quot;Encounter&quot; cards that players will draw as they interact with the citizens of newly explored lands. Each encounter card provides the player with several options, allowing them to mitigate the luck of the draw through their selection. Combat is also driven by choices, not luck or randomness.<br /><br /><em>Scythe</em> uses a streamlined action-selection mechanism (no rounds or phases) to keep gameplay moving at a brisk pace and reduce downtime between turns. While there is plenty of direct conflict for players who seek it, there is no player elimination.<br /><br />Every part of <em>Scythe</em> has an aspect of engine-building to it. Players can upgrade actions to become more efficient, build structures that improve their position on the map, enlist new recruits to enhance character abilities, activate mechs to deter opponents from invading, and expand their borders to reap greater types and quantities of resources. These engine-building aspects create a sense of momentum and progress throughout the game. The order in which players improve their engine adds to the unique feel of each game, even when playing one faction multiple times.</p>", "https://cdn.shopify.com/s/files/1/0513/4077/1515/products/scythe-board-game.jpg?v=1611090922", "72.37" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "BoardGames");

            migrationBuilder.DropColumn(
                name: "image_url",
                table: "BoardGames");

            migrationBuilder.DropColumn(
                name: "price_ca",
                table: "BoardGames");

            migrationBuilder.AlterColumn<string>(
                name: "price",
                table: "BoardGames",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: "TAAifFP590",
                column: "price",
                value: "50.00");
        }
    }
}
