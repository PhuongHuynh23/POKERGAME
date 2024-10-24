using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Media;

namespace CK
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






        // ---------------------------------------------- Define Card class --------------------------------------------------
        public class Card
        {
            public string Suit { get; private set; }
            public string Rank { get; private set; }

            public Card(string suit, string rank)
            {
                Suit = suit;
                Rank = rank;
            }

            public override string ToString()
            {
                return $"{Rank} of {Suit}";
            }
        }

        // ---------------------------------------------- Define Deck class --------------------------------------------------
        public class Deck
        {
            private List<Card> cards;
            private static readonly string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            private static readonly string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            private Random random = new Random();

            public Deck()
            {
                cards = new List<Card>();
                foreach (var suit in suits)
                {
                    foreach (var rank in ranks)
                    {
                        cards.Add(new Card(suit, rank));
                    }
                }
                Shuffle();
            }

            public void Shuffle()
            {
                int n = cards.Count;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    Card value = cards[k];
                    cards[k] = cards[n];
                    cards[n] = value;
                }
            }

            public Card DealCard()
            {
                if (cards.Count > 0)
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
            public string Name { get; private set; }
            public List<Card> Hand { get; private set; }
            public int Chips { get; set; }
            public int CurrentBet { get; private set; }
            public bool InGame { get; private set; }
            public bool HasFolded { get; set; }
            public bool HasRaised { get; set; }
            public bool HasRaisedInRound { get; set; }
            public bool IsAI { get; private set; }

            public Player(string name, bool isAI = false)
            {
                Name = name;
                Hand = new List<Card>();
                Chips = 100;
                CurrentBet = 0;
                InGame = true;
                IsAI = isAI;
                HasFolded = false;
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
                if (amount > Chips)
                    throw new Exception("Not enough chips to bet that amount.");

                Chips -= amount;
                CurrentBet += amount;
            }

            public void Fold()
            {
                InGame = false;
                HasFolded = true;
            }
            public void ResetRaiseStatus()
            {
                HasRaised = false;
            }

            public void ResetBet()
            {
                CurrentBet = 0;
            }
            public void ResetForNewRound()
            {
                CurrentBet = 0;
                HasRaisedInRound = false;  // Reset the flag for a new betting round
            }
        }

        // ------------------------------------------ Define HandEvaluator class --------------------------------------------
        public class HandEvaluator
        {
            public static readonly Dictionary<string, int> rankValues = new Dictionary<string, int>
    {
        { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 }, { "7", 7 },
        { "8", 8 }, { "9", 9 }, { "10", 10 }, { "J", 11 }, { "Q", 12 }, { "K", 13 }, { "A", 14 }
    };

            public static int EvaluateHandStrength(List<Card> playerHand, List<Card> communityCards)
            {
                var allCards = playerHand.Concat(communityCards).ToList();
                var groupedByRank = allCards.GroupBy(card => card.Rank).ToList();
                var groupedBySuit = allCards.GroupBy(card => card.Suit).ToList();

                if (IsFourOfAKind(groupedByRank)) return 8;
                if (IsFullHouse(groupedByRank)) return 7;
                if (IsFlush(groupedBySuit)) return 6;
                if (IsStraight(allCards)) return 5;
                if (IsThreeOfAKind(groupedByRank)) return 4;
                if (IsTwoPair(groupedByRank)) return 3;
                if (IsOnePair(groupedByRank)) return 2;

                return GetHighCardValue(allCards);
            }

            public static bool IsFourOfAKind(List<IGrouping<string, Card>> groupedByRank)
            {
                return groupedByRank.Any(group => group.Count() == 4);
            }

            public static bool IsFullHouse(List<IGrouping<string, Card>> groupedByRank)
            {
                return groupedByRank.Count == 2 && groupedByRank.Any(group => group.Count() == 3);
            }

            public static bool IsFlush(List<IGrouping<string, Card>> groupedBySuit)
            {
                return groupedBySuit.Any(group => group.Count() >= 5);
            }

            public static bool IsStraight(List<Card> allCards)
            {
                var orderedRanks = allCards.Select(card => rankValues[card.Rank]).Distinct().OrderBy(rank => rank).ToList();
                if (orderedRanks.Count < 5) return false;

                for (int i = 0; i <= orderedRanks.Count - 5; i++)
                {
                    if (orderedRanks[i + 4] - orderedRanks[i] == 4)
                        return true;
                }

                // Check for Ace-high straight (A, 2, 3, 4, 5)
                if (orderedRanks.Contains(14) && orderedRanks.Take(4).SequenceEqual(new List<int> { 2, 3, 4, 5 }))
                    return true;

                return false;
            }

            public static bool IsThreeOfAKind(List<IGrouping<string, Card>> groupedByRank)
            {
                return groupedByRank.Any(group => group.Count() == 3);
            }

            public static bool IsTwoPair(List<IGrouping<string, Card>> groupedByRank)
            {
                return groupedByRank.Count(group => group.Count() == 2) == 2;
            }

            public static bool IsOnePair(List<IGrouping<string, Card>> groupedByRank)
            {
                return groupedByRank.Any(group => group.Count() == 2);
            }

            public static int GetHighCardValue(List<Card> allCards)
            {
                return allCards.Max(card => rankValues[card.Rank]);
            }
        }

        // -------------------------------------------- Define PokerGame class ----------------------------------------------
        public class PokerGame
        {
            private Deck deck;
            private List<Player> players;
            private List<Card> communityCards;
            private int totalGamePot;

            public PokerGame(List<Player> players)
            {
                deck = new Deck();
                this.players = players;
                communityCards = new List<Card>();
                totalGamePot = 0;
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

            public int AiDecision(Player player, int highestBet)
            {
                if (!player.InGame) return highestBet;

                Console.WriteLine($"{player.Name}'s (AI) turn. Current chips: {player.Chips}");

                // If the player's current bet matches the highest bet, they should check or call, but not raise.
                if (player.CurrentBet == highestBet)
                {
                    Console.WriteLine($"{player.Name} checks.");
                    return highestBet;  // No further action, just checking
                }

                // AI logic to decide between calling or raising
                string action = (highestBet == 0 || new Random().Next(2) == 0) ? "call" : "raise";

                switch (action)
                {
                    case "call":
                        int betAmount = highestBet - player.CurrentBet;
                        if (betAmount > 0)
                        {
                            player.Bet(betAmount);
                            Console.WriteLine($"{player.Name} calls with {betAmount} chips.");
                        }
                        break;

                    case "raise":
                        // Prevent raising if the player has already raised this round
                        if (!player.HasRaisedInRound && highestBet > 0)  // Only allow raising if no previous raise
                        {
                            int raiseAmount = new Random().Next(1, Math.Min(10, player.Chips));  // Random raise amount
                            int totalBet = highestBet + raiseAmount;
                            player.Bet(totalBet - player.CurrentBet);
                            Console.WriteLine($"{player.Name} raises to {totalBet} chips.");
                            highestBet = totalBet;

                            // Set the flag to true after raising, preventing more raises in this round
                            player.HasRaisedInRound = true;
                        }
                        break;
                }

                return highestBet;
            }

            public int PlayerDecision(Player player, int highestBet)
            {
                if (!player.InGame || player.HasFolded) return highestBet;

                Console.WriteLine($"{player.Name}'s turn. Current chips: {player.Chips}. Highest bet: {highestBet}");

                while (true) // Keep asking for input until a valid action is chosen
                {
                    Console.Write($"{player.Name}, do you want to fold, call, or raise? ");
                    string action = Console.ReadLine().Trim().ToLower();

                    switch (action)
                    {
                        case "fold":
                            player.Fold();
                            Console.WriteLine($"{player.Name} folds.");
                            return highestBet;  // No change in the highest bet

                        case "call":
                            int betAmount = highestBet - player.CurrentBet;
                            if (betAmount > 0)  // Only bet if there's a call to make
                            {
                                player.Bet(betAmount);
                                Console.WriteLine($"{player.Name} calls with {betAmount} chips.");
                            }
                            else
                            {
                                Console.WriteLine($"{player.Name} checks.");
                            }
                            return highestBet;

                        case "raise":
                            Console.Write("Enter the raise amount: ");
                            if (int.TryParse(Console.ReadLine(), out int raiseAmount) && raiseAmount > 0)
                            {
                                int totalBet = highestBet + raiseAmount;
                                player.Bet(totalBet - player.CurrentBet);
                                Console.WriteLine($"{player.Name} raises to {totalBet} chips.");
                                return totalBet;  // Return the new highest bet
                            }
                            else
                            {
                                Console.WriteLine("Invalid raise amount. Try again.");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid action. Please enter 'fold', 'call', or 'raise'.");
                            break;
                    }
                }
            }

            public void BettingRound()
            {
                Console.WriteLine("\nStarting a new betting round....");
                int highestBet = 0;
                bool isBettingRoundOver = false;

                // Reset raise flags and current bets for all players at the start of the round
                foreach (var player in players)
                {
                    player.ResetForNewRound();
                }

                while (!isBettingRoundOver)
                {
                    isBettingRoundOver = true;

                    foreach (var player in players)
                    {
                        if (!player.InGame || player.HasFolded) continue;  // Skip players who folded or are not in the game

                        int playerBet = player.IsAI ? AiDecision(player, highestBet) : PlayerDecision(player, highestBet);

                        if (playerBet > highestBet)
                        {
                            highestBet = playerBet;
                            isBettingRoundOver = false;  // Continue the round if there's a new highest bet
                        }
                    }

                    // Check if all players have either matched the highest bet or folded
                    bool allCalledOrFolded = players.All(p => !p.InGame || p.CurrentBet == highestBet || p.HasFolded);

                    if (allCalledOrFolded)
                    {
                        isBettingRoundOver = true;
                    }
                }

                Console.WriteLine("Betting round is over.");

                // Reset raise status for all players at the end of the round
                foreach (var player in players)
                {
                    player.ResetRaiseStatus();
                }
            }
            public int CalculateTotalPotForGameRound()
            {
                int totalPotForRound = 0;

                // Duyệt qua tất cả người chơi để tính tổng số tiền họ đã đặt cược trong toàn bộ lượt chơi
                foreach (var player in players)
                {
                    totalPotForRound += player.CurrentBet;  // Cộng số tiền cược của từng người chơi vào tổng pot
                }

                totalGamePot += totalPotForRound;  // Cập nhật tổng pot cho toàn bộ game (tất cả lượt chơi)
                return totalPotForRound;  // Trả về tổng pot của lượt chơi hiện tại
            }

            public void DisplayHandStrength(Player player, List<Card> communityCards)
            {
                int handStrength = HandEvaluator.EvaluateHandStrength(player.Hand, communityCards);
                string handDescription = GetHandDescription(handStrength);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"                      {player.Name} has a hand strength of {handStrength} with {handDescription}");
                Console.ResetColor();
            }

            public string GetHandDescription(int handStrength)
            {
                return handStrength switch
                {
                    8 => "Four of a Kind",
                    7 => "Full House",
                    6 => "Flush",
                    5 => "Straight",
                    4 => "Three of a Kind",
                    3 => "Two Pair",
                    2 => "One Pair",
                    1 => "High Card",
                    _ => "Unknown"
                };
            }

            public List<Player> FindWinner()
            {
                List<Player> winners = new List<Player>();
                int bestHandStrength = 0;

                foreach (var player in players)
                {
                    if (player.InGame)
                    {
                        int handStrength = HandEvaluator.EvaluateHandStrength(player.Hand, communityCards);

                        if (handStrength > bestHandStrength)
                        {
                            bestHandStrength = handStrength;
                            winners.Clear(); // Clear previous winners
                            winners.Add(player);
                        }
                        else if (handStrength == bestHandStrength)
                        {
                            winners.Add(player); // Add to winners if tied
                        }
                    }
                }

                return winners; // Return the list of winners
            }
            public void Showdown()
            {
                Frame.Screen(84, 28);
                Frame.Music();
                Frame.Drawshowdown();
                foreach (var player in players)
                {
                    if (player.InGame && !player.HasFolded)
                    {
                        DisplayHandStrength(player, communityCards); // Display each player's hand and strength
                    }
                }

                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("                          Press any key to continue....");
                Console.ReadKey();


                Frame.Screen(84, 28);
                Console.SetCursorPosition((84) / 2 - 5, 28 / 2);

                List<Player> winners = FindWinner(); // Get all winners

                if (winners.Count == 1) // One winner
                {
                    Player winner = winners[0];
                    int winningHandStrength = HandEvaluator.EvaluateHandStrength(winner.Hand, communityCards);
                    string winningHandDescription = GetHandDescription(winningHandStrength);
                    Frame.Drawwinner();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"                                         {winner.Name}!!!
                       {winner.Name} wins the pot of {totalGamePot} chips with a {winningHandDescription}!");
                    winner.Chips += totalGamePot; // Winner takes the pot
                    Console.ResetColor();

                }
                else // Multiple winners, split the pot
                {
                    int splitAmount = totalGamePot / winners.Count; // Calculate split amount
                    Frame.DrawTie();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine(@$"                    The pot of {totalGamePot} chips 
                                                     will be split among {winners.Count} players.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();

                    foreach (var winner in winners)
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.WriteLine($"                                   {winner.Name} receives {splitAmount} chips.");


                        Console.ResetColor();

                        winner.Chips += splitAmount; // Distribute the chips evenly
                    }
                }
            }

            public void SaveResult()
            {
                Console.WriteLine();
                Console.WriteLine();
                try
                {
                    string filePath = "PokerGameResult.txt";  // File name to store the result
                    using (StreamWriter writer = new StreamWriter(filePath, true))  // Append mode
                    {
                        writer.WriteLine($"Game Result: {DateTime.Now}");
                        foreach (var player in players)
                        {
                            writer.WriteLine($"{player.Name}: {player.Chips} - Folded: {player.HasFolded}");
                        }
                        writer.WriteLine($"Total Pot: {totalGamePot}");
                        writer.WriteLine("------------------------------");
                    }

                    Console.WriteLine("                              Game result saved successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while saving the result: {ex.Message}");
                }
                Console.ReadKey();

            }

            public void Play()
            {
                // Initial deal
                DealHands();

                // Show players' hands
                foreach (var player in players)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{player.Name}'s hand: {player.ShowHand()}");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDEALING THE PRE-FLOP...");
                Console.ResetColor();
                // First betting round 
                BettingRound();

                Thread.Sleep(10000);
                Console.Clear();
                int totalPotAfterRound1 = CalculateTotalPotForGameRound();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Total pot after round 1: {totalPotAfterRound1} chips");
                Console.ResetColor();

                // Deal community cards 
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
                // Second betting round
                BettingRound();

                Thread.Sleep(10000);
                Console.Clear();
                int totalPotAfterRound2 = CalculateTotalPotForGameRound();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Total pot after round 2: {totalPotAfterRound2} chips");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDEALING THE TURN...");
                DealCommunityCards(1);
                Console.WriteLine($"Community Cards: {ShowCommunityCards()}");
                foreach (var player in players)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine($"{player.Name}'s hand: {player.ShowHand()}");
                    Console.ResetColor();
                }
                // Third betting round 
                BettingRound();


                Thread.Sleep(10000);
                Console.Clear();
                int totalPotAfterRound3 = CalculateTotalPotForGameRound();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Total pot after round 3: {totalPotAfterRound3} chips");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDEALING THE RIVER...");
                Console.ResetColor();
                DealCommunityCards(1);
                Console.WriteLine($"Community Cards: {ShowCommunityCards()}");
                foreach (var player in players)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine($"{player.Name}'s hand: {player.ShowHand()}");
                    Console.ResetColor();
                }
                // Final betting round
                BettingRound();
                Thread.Sleep(10000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                int totalPotAfterRound4 = CalculateTotalPotForGameRound();
                Console.WriteLine($"Total pot after round 4: {totalPotAfterRound4} chips");
                Console.ResetColor();

                // Showdown (simplified)
                foreach (var player in players)
                {
                    if (player.InGame)
                    {
                        Console.WriteLine($"{player.Name}'s final hand: {player.ShowHand()}");
                    }
                }
                Console.WriteLine($"Final pot after all betting rounds: {totalGamePot} chips");

                Showdown();

                // Save the game result
                SaveResult();
            }
        }

        // ---------------------------------------- Main program to initiate a game ------------------------------------------
        public class Program
        {
            public static void main()
            {
                var players = new List<Player>
        {
            new Player("Alice"),
            new Player("Bob (AI)", true)
        };

                PokerGame game = new PokerGame(players);
                game.Play();
                Console.ReadKey();
            }
        }


    }
}

       