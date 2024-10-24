using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Numerics;
using System.Media;
namespace CK
{
    internal class TEST
    {
        public class Frame
        {
            public static void Screen(int width, int height)
            {
                Console.Clear();


                // Vẽ hàng trên cùng
                Console.WriteLine(new string('-', width + 2));

                // Vẽ các hàng giữa
                for (int i = 0; i < height; i++)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', width));
                    Console.WriteLine("|");
                }

                // Vẽ hàng dưới cùng
                Console.WriteLine(new string('-', width + 2));
                //Console.SetCursorPosition((width) / 2 - 5, height / 2);

            }

            public static void Music()
            {
                SoundPlayer player = new SoundPlayer();
                try
                {
                    player.SoundLocation = "C:\\Users\\ADMIN\\Documents\\CK\\CK\\FILE NHAC\\brass-fanfare-with-timpani-and-winchimes-reverberated-146260-VEED.wav";
                    player.PlayLooping();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Không thể phát nhạc: " + e.Message);
                }
            }
            public static void Drawshowdown()
            {
                string[] showdown = new string[]
               {


@"█▀ █░█ █▀█ █░█░█ █▀▄ █▀█ █░█░█ █▄░█",
@"▄█ █▀█ █▄█ ▀▄▀▄▀ █▄▀ █▄█ ▀▄▀▄▀ █░▀█",
               };



                int startY = 10;  // Starting Y position for the text
                int currentY = startY;
                foreach (string s in showdown)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((84) / 2 - s.Length / 2, currentY);

                    Console.WriteLine(s);
                    currentY++;

                }
                Console.ResetColor();
            }

            public static void Drawwinner()
            {
                string[] drawiner = new string[]
                {

@"▀█▀ █░█ █▀▀   █░█░█ █ █▄░█ █▄░█ █▀▀ █▀█   █ █▀",
@"░█░ █▀█ ██▄   ▀▄▀▄▀ █ █░▀█ █░▀█ ██▄ █▀▄   █ ▄█",
                };
                int startY = 10;  // Starting Y position for the text
                int currentY = startY;
                foreach (string s in drawiner)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((84) / 2 - s.Length / 2, currentY);

                    Console.WriteLine(s);
                    currentY++;

                }
                Console.ResetColor();
                Console.WriteLine();
            }
            public static void DrawTie()
            {
                string[] drawtie = new string[]
                {

@"▀█▀ █ █▀▀",
@"░█░ █ ██▄",
                };
                int startY = 10;  // Starting Y position for the text
                int currentY = startY;
                foreach (string s in drawtie)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((84) / 2 - s.Length / 2, currentY);

                    Console.WriteLine(s);
                    currentY++;

                }
                Console.ResetColor();
                Console.WriteLine();
            }

        }

        public class Opening
        {
            public static void DrawPoker()
            {
                string[] PokerKing = new string[]
                {

@"██████╗░░█████╗░██╗░░██╗███████╗██████╗░  ██╗░░██╗██╗███╗░░██╗░██████╗░░██████╗",
@"██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗  ██║░██╔╝██║████╗░██║██╔════╝░██╔════╝",
@"██████╔╝██║░░██║█████═╝░█████╗░░██████╔╝  █████═╝░██║██╔██╗██║██║░░██╗░╚█████╗░",
@"██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██╔══██╗  ██╔═██╗░██║██║╚████║██║░░╚██╗░╚═══██╗",
@"██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░░██║  ██║░╚██╗██║██║░╚███║╚██████╔╝██████╔╝",
@"╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝  ╚═╝░░╚═╝╚═╝╚═╝░░╚══╝░╚═════╝░╚═════╝░",
                };
                int startY = 10;  // Starting Y position for the text
                int currentY = startY;
                foreach (string s in PokerKing)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition((84) / 2 - s.Length / 2, currentY);

                    Console.WriteLine(s);
                    currentY++;

                }
                Console.ResetColor();
            }

            public static void DrawWelcometo()
            {
                string[] Wel = new string[]
                {
                    @"𝑾𝒆𝒍𝒄𝒐𝒎𝒆 𝒕𝒐",
                };
                int startY = 10;  // Starting Y position for the text
                int currentY = startY;
                foreach (string s in Wel)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition((84) / 2 - s.Length / 2, currentY);

                    Console.WriteLine(s);
                    currentY++;

                }
                Console.ResetColor();
            }
            public static void MusicOpening()
            {
                SoundPlayer musicOpening = new SoundPlayer();
                musicOpening.SoundLocation = "C:\\Users\\ADMIN\\Documents\\CK\\CK\\FILE NHAC\\Wallpaper(chosic.com).wav";
                musicOpening.Play();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                          Press any key to continue....");
                Console.ResetColor();
                Console.ReadKey();

                // Dừng phát
                musicOpening.Stop();
            }
            public static void MusicOpening1()
            {
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = "C:\\Users\\ADMIN\\Documents\\CK\\CK\\FILE NHAC\\Wallpaper(chosic.com).wav";
                sound.Play();

                Console.ReadKey();
                sound.Stop();
            }
        }

        // ---------------------------------------------- Define Card class --------------------------------------------------
        public class Card
        {
            public string Suit { get; private set; } // dùng get và private set để đọc giá trị và
                                                     // không thể thay đổi giá trị từ bên ngoài
            public string Rank { get; private set; }

            public Card(string suit, string rank)
            {
                Suit = suit;
                Rank = rank;
            }

            public override string ToString() // dùng override để ghi đè lên
            {
                return $"{Rank} of {Suit}";
            }
        }

        // ---------------------------------------------- Define Deck class --------------------------------------------------
        public class Deck // giúp quan lí bộ bài trong trò chơi để xào bài và rút bài
        {
            private List<Card> cards;
            private static readonly string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            private static readonly string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            private Random random = new Random();

            public Deck()
            {
                cards = new List<Card>();
                foreach (var suit in suits) // dùng foreach bên trong sẽ duyệt qua tất cả các giá trị suits và ranks 
                                            // để tạo các lá bài thành 52 lá
                {
                    foreach (var rank in ranks)
                    {
                        cards.Add(new Card(suit, rank));
                    }
                }
                Shuffle(); // sau khi tạo xong thì sẽ xào bài
            }

            public void Shuffle() // tráo đổi vị trí của các lá bài 
            {
                int n = cards.Count;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    Card value = cards[k];
                    cards[k] = cards[n];
                    cards[n] = value; //mỗi lần sẽ chọn ngẫu nhiên một lá bài để tráo đổi vị trí với lá bài hiện tại.


                }
            }

            public Card DealCard()
            {
                if (cards.Count > 0) // nếu true thì tiếp tục và false thì trả về null
                {
                    var card = cards[^1];
                    cards.RemoveAt(cards.Count - 1);
                    return card;
                }
                return null;
            }
        }

        // --------------------------------------------- Define Player class -------------------------------------------------
        public class Player
        {
            public string Name { get; set; }
            public List<Card> Hand { get; set; }
            public int Chips { get; set; }
            public int CurrentBet { get; set; }
            public bool InGame { get; set; }
            public bool HasFolded { get; set; }
            public bool IsAllIn { get; set; }

            public Player(string name)
            {
                Name = name;
                Hand = new List<Card>();
                Chips = 100;
                CurrentBet = 0;
                InGame = true;
                HasFolded = false;
                IsAllIn = false;
            }

            public void ReceiveCard(Card card)
            {
                Hand.Add(card);
            }

            public string ShowHand()
            {
                return string.Join(", ", Hand);
            }

            public void Bet(int amount)
            {
                if (amount >= Chips)
                {
                    AllIn(); // Người chơi tự động all-in nếu không còn đủ chip
                }
                else
                {
                    Chips -= amount;
                    CurrentBet += amount;
                }
            }


            public void Fold()
            {
                InGame = false;
                HasFolded = true;
            }

            public void AllIn()
            {
                CurrentBet += Chips;
                Chips = 0;
                IsAllIn = true;
                InGame = true; // Người chơi vẫn còn trong game, nhưng không thể thêm cược
            }

            public void ResetBet()
            {
                CurrentBet = 0;
            }
        }

        // ------------------------------------------ Define HandEvaluator class ---------------------------------------------
        public class HandEvaluator
        {
            public static readonly Dictionary<string, int> rankValues = new Dictionary<string, int>
    {
        { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 }, { "7", 7 },
        { "8", 8 }, { "9", 9 }, { "10", 10 }, { "J", 11 }, { "Q", 12 }, { "K", 13 }, { "A", 14 }
    };

            // Hàm đánh giá sức mạnh của tay bài và trả về điểm
            public static (int handStrength, string description) EvaluateHand(List<Card> playerHand, List<Card> communityCards)
            {
                var allCards = playerHand.Concat(communityCards).ToList();
                var groupedByRank = allCards.GroupBy(card => card.Rank).ToList();
                var groupedBySuit = allCards.GroupBy(card => card.Suit).ToList();

                // Xác định tay bài
                if (IsFourOfAKind(groupedByRank)) return (8, "Four of a Kind");
                if (IsFullHouse(groupedByRank)) return (7, "Full House");
                if (IsFlush(groupedBySuit)) return (6, "Flush");
                if (IsStraight(allCards)) return (5, "Straight");
                if (IsThreeOfAKind(groupedByRank)) return (4, "Three of a Kind");
                if (IsTwoPair(groupedByRank)) return (3, "Two Pair");
                if (IsOnePair(groupedByRank)) return (2, "One Pair");

                // Nếu không có kết hợp, trả về High Card
                int highCardValue = GetHighCardValue(allCards);
                return (1, $"High Card: {GetCardName(highCardValue)}");
            }

            // Các hàm phụ để xác định loại tay bài
            public static bool IsFourOfAKind(List<IGrouping<string, Card>> groupedByRank) =>
                groupedByRank.Any(group => group.Count() == 4);

            public static bool IsFullHouse(List<IGrouping<string, Card>> groupedByRank) =>
                groupedByRank.Count == 2 && groupedByRank.Any(group => group.Count() == 3);

            public static bool IsFlush(List<IGrouping<string, Card>> groupedBySuit) =>
                groupedBySuit.Any(group => group.Count() >= 5);

            public static bool IsStraight(List<Card> allCards)
            {
                var orderedRanks = allCards.Select(card => rankValues[card.Rank]).Distinct().OrderBy(rank => rank).ToList();
                if (orderedRanks.Count < 5) return false;

                for (int i = 0; i <= orderedRanks.Count - 5; i++)
                {
                    if (orderedRanks[i + 4] - orderedRanks[i] == 4) return true;
                }

                // Xử lý trường hợp sảnh (A, 2, 3, 4, 5)
                return orderedRanks.Contains(14) && orderedRanks.Take(4).SequenceEqual(new List<int> { 2, 3, 4, 5 });
            }

            public static bool IsThreeOfAKind(List<IGrouping<string, Card>> groupedByRank) =>
                groupedByRank.Any(group => group.Count() == 3);

            public static bool IsTwoPair(List<IGrouping<string, Card>> groupedByRank) =>
                groupedByRank.Count(group => group.Count() == 2) == 2;

            public static bool IsOnePair(List<IGrouping<string, Card>> groupedByRank) =>
                groupedByRank.Any(group => group.Count() == 2);

            // Trả về giá trị lá bài cao nhất
            public static int GetHighCardValue(List<Card> allCards) =>
                allCards.Max(card => rankValues[card.Rank]);

            // Hàm tiện ích để chuyển giá trị lá bài thành tên
            public static string GetCardName(int cardValue)
            {
                return rankValues.FirstOrDefault(x => x.Value == cardValue).Key;
            }
        }

        // -------------------------------------------- Define PokerGame class -----------------------------------------------
        public class PokerGame
        {
            private Deck deck;
            private List<Player> players;
            private List<Card> communityCards;
            private int totalGamePot;
            private int smallBlindPosition;
            private int bigBlindPosition;
            private const int smallBlindAmount = 5; // Giá trị của small blind
            private const int bigBlindAmount = 10;   // Giá trị của big blind

            public PokerGame(List<Player> players)
            {
                deck = new Deck();
                this.players = players;
                communityCards = new List<Card>();
                totalGamePot = 0;
                smallBlindPosition = 0;
                bigBlindPosition = 1;
            }

            // Phương thức đặt Small Blind và Big Blind
            private void PostBlinds()
            {
                PlaceBlind(smallBlindPosition, smallBlindAmount, "Small Blind");
                PlaceBlind(bigBlindPosition, bigBlindAmount, "Big Blind");
                totalGamePot += smallBlindAmount + bigBlindAmount;
            }

            private void PlaceBlind(int position, int blindAmount, string blindName)
            {
                Player player = players[position];
                player.Bet(blindAmount);
                Console.WriteLine($"{player.Name} posts {blindName} of {blindAmount} chips.");
            }

            public void DealHands()
            {
                for (int i = 0; i < 2; i++)
                {
                    foreach (var player in players)
                    {
                        player.ReceiveCard(deck.DealCard());
                    }
                }
            }

            public void DealCommunityCards(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    communityCards.Add(deck.DealCard());
                }
            }

            public string ShowCommunityCards()
            {
                return string.Join(", ", communityCards);
            }

            private int PlayerDecision(Player player, int highestBet)
            {
                if (!player.InGame || player.HasFolded) return highestBet;

                Console.WriteLine($"{player.Name}'s turn. Current chips: {player.Chips}. Highest bet: {highestBet}");

                // Allow "call" as "check" when highestBet == 0
                string[] validActions = new[] { "fold", "call", "raise", "all-in" };
                string action = GetValidAction(player.Name, validActions);

                switch (action)
                {
                    case "fold":
                        player.Fold();
                        Console.WriteLine($"{player.Name} folds.");
                        return highestBet;

                    case "call":
                        if (highestBet == 0)
                        {
                            Console.WriteLine($"{player.Name} checks.");
                            return highestBet; // No change in bet amount when checking
                        }
                        else
                        {
                            return ExecuteCall(player, highestBet);
                        }

                    case "raise":
                        return ExecuteRaise(player, highestBet);

                    case "all-in":
                        int allInAmount = player.Chips; // All remaining chips
                        player.AllIn(); // Mark the player as all-in
                        Console.WriteLine($"{player.Name} goes all-in with {allInAmount} chips.");
                        return Math.Max(highestBet, player.CurrentBet + allInAmount); // Update highest bet if necessary
                }

                return highestBet;
            }

            private string GetValidAction(string playerName, string[] validActions)
            {
                string action;
                do
                {
                    Console.Write($"{playerName}, choose an action ({string.Join(", ", validActions)}): ");
                    action = Console.ReadLine().Trim().ToLower();
                } while (!validActions.Contains(action));
                return action;
            }

            private int ExecuteCall(Player player, int highestBet)
            {
                int callAmount = highestBet - player.CurrentBet;
                if (player.Chips <= callAmount)
                {
                    // Player goes all-in if they can't match the bet
                    callAmount = player.Chips;
                    player.AllIn();
                    Console.WriteLine($"{player.Name} calls and goes all-in with {callAmount} chips.");
                }
                else
                {
                    player.Bet(callAmount);
                    Console.WriteLine($"{player.Name} calls with {callAmount} chips.");
                }

                return highestBet;
            }

            private int ExecuteRaise(Player player, int highestBet)
            {
                int raiseAmount;
                do
                {
                    Console.Write("Enter the raise amount: ");
                } while (!int.TryParse(Console.ReadLine(), out raiseAmount) || raiseAmount <= 0);

                int totalBet = highestBet + raiseAmount;
                if (player.Chips <= (totalBet - player.CurrentBet))
                {
                    // Player goes all-in if they don't have enough to raise
                    totalBet = player.Chips + player.CurrentBet;
                    player.AllIn();
                    Console.WriteLine($"{player.Name} raises and goes all-in with {totalBet} chips.");
                }
                else
                {
                    player.Bet(totalBet - player.CurrentBet);
                    Console.WriteLine($"{player.Name} raises to {totalBet} chips.");
                }

                return totalBet;
            }

            public enum GameRound { PreFlop, Flop, Turn, River }

            public void StartBettingRound(GameRound round)
            {
                Console.WriteLine($"\nStarting {round} round....");
                int highestBet = (round == GameRound.PreFlop) ? bigBlindAmount : 0;  // Reset to 0 after Pre-Flop

                if (round == GameRound.PreFlop)
                {
                    PostBlinds();  // Only post blinds during Pre-Flop
                }

                BettingRound(highestBet);
            }

            public void BettingRound(int highestBet)
            {
                Console.WriteLine("\nStarting a new betting round....");

                Player currentRaiser = null;
                bool isBettingRoundOver = false;

                // Start from the player after the big blind in the pre-flop, or the first player in other rounds
                int startPosition = (highestBet > 0) ? (bigBlindPosition + 1) % players.Count : 0;

                while (!isBettingRoundOver)
                {
                    isBettingRoundOver = true;

                    for (int i = 0; i < players.Count; i++)
                    {
                        int playerPosition = (startPosition + i) % players.Count;
                        Player player = players[playerPosition];

                        if (!player.InGame || player.HasFolded || player.IsAllIn) continue; // Skip players who have folded or gone all-in

                        int playerBet = PlayerDecision(player, highestBet);
                        if (playerBet > highestBet)
                        {
                            highestBet = playerBet;
                            currentRaiser = player;
                            isBettingRoundOver = false;
                        }
                    }

                    // Check if all players have called, folded, or are all-in
                    bool allCalledOrFoldedOrAllIn = players.All(p => !p.InGame || p.CurrentBet >= highestBet || p.HasFolded || p.IsAllIn);
                    if (allCalledOrFoldedOrAllIn)
                    {
                        isBettingRoundOver = true;
                    }
                }

                int potForThisRound = CalculateTotalPotForGameRound();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"Total pot for this round: {potForThisRound} chips.");
                Console.ResetColor();
                foreach (var player in players)
                {
                    player.ResetBet(); // Reset the bet for the next round
                }
            }

            public int CalculateTotalPotForGameRound()
            {
                int totalPotForRound = 0;

                // Calculate the sum of all players' CurrentBet for the round
                foreach (var player in players)
                {
                    if (player.InGame && !player.HasFolded)  // Only count players still in the game
                    {
                        totalPotForRound += player.CurrentBet;
                    }
                }

                // Accumulate this round's pot into the total game pot
                totalGamePot += totalPotForRound;
                return totalPotForRound;  // Return the total pot for this round
            }

            public class PlayerRanking
            {
                public string Name { get; set; }
                public int HandStrength { get; set; }
                public string HandDescription { get; set; } // Add hand description

                public PlayerRanking(string name, int handStrength, string handDescription)
                {
                    Name = name;
                    HandStrength = handStrength;
                    HandDescription = handDescription;
                }
            }

            // Display the player's hand and strength
            public void DisplayHandStrength(Player player, List<Card> communityCards)
            {
                // Evaluate the player's hand strength and description
                var (handStrength, handDescription) = HandEvaluator.EvaluateHand(player.Hand, communityCards);

                // Display the result
                Console.WriteLine($"{player.Name} has a hand strength of {handStrength} with {handDescription}");
            }

            // Return a hand description based on hand strength
            public string GetHandDescription(int handStrength)
            {
                switch (handStrength)
                {
                    case 8: return "Four of a Kind";
                    case 7: return "Full House";
                    case 6: return "Flush";
                    case 5: return "Straight";
                    case 4: return "Three of a Kind";
                    case 3: return "Two Pair";
                    case 2: return "One Pair";
                    case 1: return "High Card";
                    default: return "Unknown";
                }
            }

            private bool CheckForWinner()
            {
                int activePlayers = players.Count(p => p.InGame && !p.HasFolded);

                if (activePlayers == 1)
                {
                    // Xác định người chơi duy nhất còn lại
                    Player winner = players.First(p => p.InGame && !p.HasFolded);

                    // Cộng tổng pot vào số chip của người thắng
                    winner.Chips += totalGamePot;

                    // Hiển thị thông báo người chiến thắng và số tiền thắng được
                    Console.WriteLine($"{winner.Name} wins the game as all other players have folded.");
                    Console.WriteLine($"{winner.Name} wins the pot of {totalGamePot} chips!");

                    SaveResult();

                    return true; // Kết thúc trò chơi
                }

                return false; // Tiếp tục trò chơi
            }

            // Find the winner 
            private List<Player> FindWinner()
            {
                List<Player> winners = new List<Player>();
                int bestHandStrength = 0;
                int bestHighCardValue = 0;

                foreach (var player in players.Where(p => p.InGame && !p.HasFolded))
                {
                    var (handStrength, _) = HandEvaluator.EvaluateHand(player.Hand, communityCards);
                    int playerHighCardValue = HandEvaluator.GetHighCardValue(player.Hand.Concat(communityCards).ToList());

                    if (handStrength > bestHandStrength)
                    {
                        bestHandStrength = handStrength;
                        bestHighCardValue = playerHighCardValue;
                        winners.Clear();
                        winners.Add(player);
                    }
                    else if (handStrength == bestHandStrength && playerHighCardValue > bestHighCardValue)
                    {
                        bestHighCardValue = playerHighCardValue;
                        winners.Clear();
                        winners.Add(player);
                    }
                    else if (handStrength == bestHandStrength && playerHighCardValue == bestHighCardValue)
                    {
                        winners.Add(player);
                    }
                }

                return winners;
            }

            // The showdown logic 
            private void Showdown()
            {
                DisplayLeaderboard();
                List<Player> winners = FindWinner();

                if (winners.Count == 1)
                {
                    Frame.Drawwinner();
                    AwardWinner(winners[0]);
                }
                else
                {
                    Frame.DrawTie();
                    SplitPotAmongWinners(winners);
                }
            }

            private void AwardWinner(Player winner)
            {
                var (_, handDescription) = HandEvaluator.EvaluateHand(winner.Hand, communityCards);
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(@$"                                         {winner.Name}!!!
                       {winner.Name} wins the pot of {totalGamePot} chips with a {handDescription}!");
                winner.Chips += totalGamePot;
                Console.ResetColor();
            }

            private void SplitPotAmongWinners(List<Player> winners)
            {
                int splitAmount = totalGamePot / winners.Count; // Chia đều pot cho người chơi

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(@$"                    The pot of {totalGamePot} chips 
                                                     will be split among {winners.Count} players.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < winners.Count; i++)
                {
                    Player winner = winners[i];
                    int chipsAwarded = splitAmount; // Mỗi người chơi nhận số chip chia đều
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine($"                                   {winner.Name} receives {splitAmount} chips.");


                    Console.ResetColor();
                    winner.Chips += chipsAwarded;
                }
            }

            // Display the leaderboard with rank and hand description 
            public void DisplayLeaderboard()
            {
                // Lọc danh sách người chơi chỉ bao gồm những người không bỏ bài
                var activePlayers = players
                    .Where(p => p.InGame && !p.HasFolded)
                    .ToList();

                if (activePlayers.Count == 0)
                {
                    Console.WriteLine("No active players available.");
                    return;
                }

                // Tạo mảng 2D để lưu thông tin bảng xếp hạng: Tên, Mức độ mạnh của bài, Mô tả bài
                object[,] leaderboard = new object[activePlayers.Count, 3];

                // Điền thông tin vào leaderboard cho các người chơi đủ điều kiện
                for (int i = 0; i < activePlayers.Count; i++)
                {
                    Player player = activePlayers[i];
                    var (handStrength, handDescription) = HandEvaluator.EvaluateHand(player.Hand, communityCards);

                    leaderboard[i, 0] = player.Name;           // Tên người chơi
                    leaderboard[i, 1] = handStrength;          // Sức mạnh bài
                    leaderboard[i, 2] = handDescription;       // Mô tả bài
                }

                // Sắp xếp bảng xếp hạng theo sức mạnh bài (giảm dần) bằng Bubble Sort
                for (int i = 0; i < activePlayers.Count - 1; i++)
                {
                    for (int j = i + 1; j < activePlayers.Count; j++)
                    {
                        if (Convert.ToInt32(leaderboard[i, 1]) < Convert.ToInt32(leaderboard[j, 1]))
                        {
                            SwapRows(leaderboard, i, j); // Hoán đổi nếu sức mạnh bài nhỏ hơn
                        }
                    }
                }

                // Hiển thị bảng xếp hạng đã sắp xếp
                Frame.Screen(84, 28);
                Frame.Music();
                Frame.Drawshowdown();
                for (int i = 0; i < activePlayers.Count; i++)
                {
                    int rank = i + 1;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"                    #{rank}. Player {leaderboard[i, 0]} - Hand Strength: {leaderboard[i, 1]} - {leaderboard[i, 2]}");
                    Console.ResetColor();
                }
                Console.WriteLine("                          Press any key to continue...");
                Console.ReadKey();

                Frame.Screen(84, 28);
                Console.SetCursorPosition((84) / 2 - 5, 28 / 2);
            }

            // Hàm hoán đổi hai hàng trong mảng 2D
            private void SwapRows(object[,] array, int row1, int row2)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    var temp = array[row1, col];
                    array[row1, col] = array[row2, col];
                    array[row2, col] = temp;
                }
            }

            public void SaveResult()
            {
                try
                {
                    string filePath = "PokerGameResult.txt";  // File name to store the result
                    using (StreamWriter writer = new StreamWriter(filePath, true))  // Append mode
                    {
                        writer.WriteLine($"Game Result: {DateTime.Now}");
                        foreach (var player in players)
                        {
                            writer.WriteLine($"{player.Name}: {player.Chips} chips");
                        }
                        writer.WriteLine($"Total Pot: {totalGamePot} chips");
                        writer.WriteLine("------------------------------");
                    }
                    Console.WriteLine("                              Game result saved successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while saving the result: {ex.Message}");
                }
            }

            public void Play()
            {
                // Initial deal
                DealHands();

                Console.WriteLine("Player hands at the start:");
                foreach (var player in players)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine($"{player.Name}'s hand: {player.ShowHand()}");
                    Console.ResetColor();

                }
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\nDEALING THE PRE-FLOP...");
                Console.ResetColor();

                PostBlinds(); // Post blinds only for Pre-Flop

                // First betting round (Pre-Flop)
                BettingRound(bigBlindAmount);
                if (CheckForWinner()) return;
                Thread.Sleep(5000);
                Console.Clear();
                // Deal the Flop (3 cards)

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDEALING THE FLOP...");
                Console.ResetColor();
                DealCommunityCards(3);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Community Cards: {ShowCommunityCards()}");
                Console.ResetColor();
                foreach (var player in players)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine($"{player.Name}'s hand: {player.ShowHand()}");
                    Console.ResetColor();
                }
                // Second betting round (Flop)
                BettingRound(0);  // Highest bet resets to 0
                if (CheckForWinner()) return;
                Thread.Sleep(5000);
                Console.Clear();
                // Deal the Turn (1 card)

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDEALING THE TURN...");
                Console.ResetColor();
                DealCommunityCards(1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Community Cards: {ShowCommunityCards()}");
                Console.ResetColor();
                foreach (var player in players)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine($"{player.Name}'s hand: {player.ShowHand()}");
                    Console.ResetColor();
                }
                // Third betting round (Turn)
                BettingRound(0);  // Highest bet resets to 0
                if (CheckForWinner()) return;
                Thread.Sleep(5000);
                Console.Clear();
                // Deal the River (1 card)
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\nDEALING THE RIVER...");
                Console.ResetColor();

                DealCommunityCards(1);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Community Cards: {ShowCommunityCards()}");
                Console.ResetColor();
                foreach (var player in players)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine($"{player.Name}'s hand: {player.ShowHand()}");
                    Console.ResetColor();
                }
                // Final betting round (River)
                BettingRound(0);  // Highest bet resets to 0
                if (CheckForWinner()) return;



                //Console.WriteLine($"Community Cards: {ShowCommunityCards()}");

                //foreach (var player in players)
                //{
                //    if (player.InGame)
                //    {
                //        Console.WriteLine($"{playffffer.Name}'s final hand: {player.ShowHand()}");
                //    }
                //}
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Final pot after all betting rounds: {totalGamePot} chips");
                Console.ResetColor();
                Thread.Sleep(5000);

                Showdown();

                // Save the game result
                SaveResult();
            }

        }

        // ---------------------------------------- Main program to initiate a game ------------------------------------------
        public class Program
        {
            public static void Main()
            {
                Frame.Screen(84, 28);
                Opening.DrawPoker();
                Console.WriteLine();
                Opening.MusicOpening();
                SoundPlayer effect1 = new SoundPlayer();

                int numPlayers = 0;
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = "C:\\Users\\ADMIN\\Documents\\CK\\CK\\FILE NHAC\\mix-3m41s-audio-joinercom_0vmZcQv6.wav";
                sound.Play();
                do
                {
                    Console.Clear();
                    Frame.Screen(84, 28);
                    Console.SetCursorPosition((70) / 2 - 5, 22 / 2);

                    Console.Write("Enter the number of players: ");
                    numPlayers = Convert.ToInt32(Console.ReadLine());
                } while (numPlayers < 2 || numPlayers > 5);
                Console.WriteLine();

                var players = new List<Player>();
                for (int i = 0; i < numPlayers; i++)
                {
                    Console.Write($"                              Enter the name of player {i + 1}: ");
                    string playerName = Console.ReadLine();
                    players.Add(new Player(playerName));
                }
                Console.Clear();
                sound.Stop();
                PokerGame game = new PokerGame(players);
                game.Play();
                Console.ReadKey();
            }
        }

    }
}
