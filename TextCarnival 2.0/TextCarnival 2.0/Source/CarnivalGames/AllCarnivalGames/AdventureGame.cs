﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class AdventureGame : CarnivalGame
    {
        public AdventureGame() : base()
        {
            
        }

        public override string getName()
        {
            return "Adventure Game";
        }
        
        public override void play()
        {
            //Shows the green title text
            showTitle("WELCOME TO THE ADVENTURE GAME!");

            writeLine("This is an interactive game that will either end in your escape or you brutal death! Ready to play? Let's go! \n\n\n\n\n");
            writeLine("One day you go hiking in the woods. While hiking you get EXTREMELY lost. \n You come up to a huge bridge crossing over a river. \nDo you: \nA.Cross the bridge \nB.play it safe and try to find another way");
            String answer1 = Console.ReadLine();
            if ( answer1 == "B")
            {
                writeLine("You try to find a better way around but fail horribly and die soon that night. \nnice try.");
            }
            if (answer1 == "A")
            {
                writeLine("You start to cross over the bridge but half way through a troll jumps out infront of you. \nDo you: \nA. Run as fast as you can across the bridge \nB.Stand there and wait for him to talk \nC.Push him off the brige");
                String answer2 = Console.ReadLine();
                if (answer2 == "A")
                {
                    writeLine("You start to run but you trip over a broken board and fall through, plumiting to your death. \nNice try.");
                }
                if (answer2 == "C")
                {
                    writeLine("Nice. You pissed off the troll. Since its his bridge he hits the self-destruct botton killing you. \nNice try ");
                }
                if (answer2 == "B")
                {
                    writeLine("The troll says to safely pass the bridge you must answer a riddle. If you are right I will let you pass. \n Here's your riddle. \n A house has 4 walls. All of the walls are facing south, and a bear is circling the house. What color is the bear? \nA. Brown \nB.Black \nC. White");
                    String answer3 = Console.ReadLine();
                    if (answer3 == "A" || answer3 == "B")
                    {
                        writeLine("The troll says that's wrong. \nThe house is on the north pole, so the bear is white.\n He pulls out a red button and pushes it, relasing the bridge and dropping you to your death. \nNicetry.");
                    }
                    if (answer3 == "C")
                    {
                        writeLine("The troll says that's correct! and lets you pass the bridge.\n after the bridge, you see 3 paths. Pick one.\n1\n2\n3");
                        String answer4 = Console.ReadLine();
                        if( answer4 == "1" || answer4 == "3")
                        {
                            writeLine("Well that's wrong. Sorry, you die. \nnice try");
                        }
                        if( answer4 == "2")
                        {
                            writeLine("That path leads you to a dark and scary part of the woods. \nDo you: \n A.Turn around \nB.Walk through and hope for the best \nC. Take a quick nap to clear your head");
                            String answer5 = Console.ReadLine();
                            if (answer5 == "A")
                            {
                                writeLine("After turning around a bear runs out of the wood and attacks. \nnicce try.");
                            }
                            if(answer5 == "B")
                            {
                                writeLine("While walking through you step on a very deadly snack. It bites you and kills you instently. \nnice try.");
                            }
                            if (answer5 =="C")
                            {
                                writeLine("You find a nice place to take a quick slumber. After a few hours you wake up and find a note. \nDo you \nA.Act like you don't see the note \nB.Pick up the note and read it \nC. pick it up and throw it away " );
                                String answer6 = Console.ReadLine();
                                if (answer6 == "A")
                                {
                                    writeLine("You get up and start wondering around and later find out that the paper had a map on it. You die a slow and painful death in the middle of the woods. \nnice try");
                                }
                                if (answer6 == "C")
                                {
                                    writeLine("Well it was nice of you to clean upp but you just threw out your only chance of living and after a while you die. \nnice try. ");
                                }
                                if (answer6 == "B")
                                {
                                    writeLine("You pick up the paper and ISSA MAP! Do you:\nA. Say Dang i really wish i knew how to read a map \nB.Look at the map and find the way out ");
                                    String answer7 = Console.ReadLine();
                                    if (answer7 == "A")
                                    {
                                        writeLine("Well thats unfortunate. You dead.");
                                    }
                                    if(answer7 == "B")
                                    {
                                        writeLine("After 2 days, YOU MADE YOUR WAY OUT! \nCONGRATS! YOU DID IT!");
                                    }
                                }
                                
                            }

                        }
                    }
                }
            }


            }

        }

    }

