//Lauren Steel, October 31 2017, Choose you own adventure 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummativeUnit3
{
    public partial class chooseYourOwnAdventure : Form
    {
        //Tracks what part of the game the user is at
        int scene = 0;
        int theNumber;

        public chooseYourOwnAdventure()
        {
            // Random Number Generator
            Random randGen = new Random();
            theNumber = randGen.Next(1, 101);

            InitializeComponent();
            //Display Initial Message
            situationLabel.Text = "You wake up on the edge of a forest. You are curently alone and you seem to be fine other than a large gash in your left arm. You think it would be best to... ";
            aOutputLabel.Text = "Wrap up the wound with you sweater.";
            bOutputLabel.Text = "Start to srceam for help.";
        }
        private void chooseYourOwnAdventure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                //A  switches
                if (scene == 0) { scene = 2; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 7; }
                else if (scene == 7) { scene = 12; }
                else if (scene == 12) { scene = 19; }
                else if (scene == 19) { scene = 37; }
                else if (scene == 5) { scene = 9; }
                else if (scene == 9) { scene = 15; }
                else if (scene == 15) { scene = 26; }
                else if (scene == 11) { scene = 17; }
                else if (scene == 17) { scene = 32; }
                else if (scene == 16) { scene = 29; }
                else if (scene == 13) { scene = 21; }
                else if (scene == 45) { scene = 61; }
                else if (scene == 20) { scene = 40; }
                else if (scene == 22) { scene = 46; }
                else if (scene == 23) { scene = 49; }
                else if (scene == 24) { scene = 51; }
                else if (scene == 6) { scene = 53; }
                else if (scene == 25) { scene = 55; }
                else if (scene == 36) { scene = 57; }
                //Random outcomes
                else if (scene == 21 && theNumber < 65) { scene = 44; }
                else if (scene == 21 && theNumber > 65) { scene = 43; }
                else if (scene == 18 && theNumber < 65) { scene = 35; }
                else if (scene == 18 && theNumber > 65) { scene = 34; }
                else if (scene == 42 && theNumber < 85) { scene = 60; }
                else if (scene == 42 && theNumber > 85) { scene = 59; }
                else if (scene == 62 && theNumber < 85) { scene = 66; }
                else if (scene == 62 && theNumber > 85) { scene = 65; }
                else if (scene == 58 && theNumber < 85) { scene = 64; }
                else if (scene == 58 && theNumber > 85) { scene = 63; }
                //Restart after loosing
                else if (scene == 37) { scene = 0; }
                else if (scene == 38) { scene = 0; }
                else if (scene == 39) { scene = 0; }
                else if (scene == 40) { scene = 0; }
                else if (scene == 41) { scene = 0; }
                else if (scene == 59) { scene = 0; }
                else if (scene == 43) { scene = 0; }
                else if (scene == 61) { scene = 0; }
                else if (scene == 65) { scene = 0; }
                else if (scene == 46) { scene = 0; }
                else if (scene == 48) { scene = 0; }
                else if (scene == 50) { scene = 0; }
                else if (scene == 51) { scene = 0; }
                else if (scene == 52) { scene = 0; }
                else if (scene == 53) { scene = 0; }
                else if (scene == 54) { scene = 0; }
                else if (scene == 56) { scene = 0; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 1) { scene = 0; }
                else if (scene == 27) { scene = 0; }
                else if (scene == 26) { scene = 0; }
                else if (scene == 8) { scene = 0; }
                else if (scene == 10) { scene = 0; }
                else if (scene == 30) { scene = 0; }
                else if (scene == 33) { scene = 0; }
                else if (scene == 34) { scene = 0; }
                else if (scene == 57) { scene = 0; }
                else if (scene == 63) { scene = 0; }
                //Restart after winning
                else if (scene == 28) { scene = 0; }
                else if (scene == 29) { scene = 0; }
                else if (scene == 31) { scene = 0; }
                else if (scene == 32) { scene = 0; }
                else if (scene == 35) { scene = 0; }
                else if (scene == 44) { scene = 0; }
                else if (scene == 47) { scene = 0; }
                else if (scene == 49) { scene = 0; }
                else if (scene == 55) { scene = 0; }
                else if (scene == 60) { scene = 0; }
                else if (scene == 64) { scene = 0; }
                else if (scene == 66) { scene = 0; }
            }
            else if (e.KeyCode == Keys.B)
            {
                //B switches
                if (scene == 0) { scene = 1; }
                else if (scene == 5) { scene = 10; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 8; }
                else if (scene == 7) { scene = 13; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 13) { scene = 22; }
                else if (scene == 15) { scene = 27; }
                else if (scene == 16) { scene = 30; }
                else if (scene == 22) { scene = 47; }
                else if (scene == 14) { scene = 24; }
                else if (scene == 24) { scene = 52; }
                else if (scene == 25) { scene = 56; }
                else if (scene == 21) { scene = 45; }
                else if (scene == 45) { scene = 62; }
                else if (scene == 12) { scene = 20; }
                else if (scene == 20) { scene = 41; }
                else if (scene == 19) { scene = 38; }
                else if (scene == 6) { scene = 54; }
                else if (scene == 23) { scene = 50; }
                else if (scene == 11) { scene = 18; }
                else if (scene == 17) { scene = 33; }
                else if (scene == 18) { scene = 36; }
                else if (scene == 36) { scene = 58; }


               
            }
            else if (e.KeyCode == Keys.C)
            {
                //C switches
                if (scene == 2) { scene = 5; }
                else if (scene == 5) { scene = 11; }
                else if (scene == 15) { scene = 28; }
                else if (scene == 16) { scene = 31; }
                else if (scene == 7) { scene = 14; }
                else if (scene == 19) { scene = 39; }
                else if (scene == 20) { scene = 42; }
                else if (scene == 22) { scene = 48; }
                else if (scene == 14) { scene = 25; }
                else if (scene == 24) { scene = 6; }
            }
            switch (scene)
            {
                case 0:  //start scene 
                    situationLabel.Text = "You wake up on the edge of a forest. You are curently alone and you seem to be fine other than a large gash in your left arm. You think it would be best to... ";
                    aOutputLabel.Text = "Wrap up the wound with you sweater."; //goes to scene 2
                    bOutputLabel.Text = "Start to srceam for help."; //goes to scene 1
                    cOutputLabel.Text = "";
                    break;
                case 1:
                    situationLabel.Text = "No one comes for you, well, no human comes for you. A large agressive animal comes and attacks you, because you are weak, you are unable to defend yourself. You suffer an unimaginable death. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 2:
                    situationLabel.Text = "You lift yourself up and the way you see it you have three different ways to go. You choose to go...";
                    aOutputLabel.Text = "To the beach that you can see vaguely through the trees."; //goes to scene 3
                    bOutputLabel.Text = "Deeper into the forest."; //goes to scene 4
                    cOutputLabel.Text = "Up the small mountain to get a better view."; //goes to scene 5
                    break;
                case 3:
                    situationLabel.Text = "As you make your way across the beach you notice many other injured passengers so you...";
                    aOutputLabel.Text = "Stop to try and help."; //goes to scene 7
                    bOutputLabel.Text = "Hate blood and know you can't help so you head to the water."; //goes to scene 8
                    cOutputLabel.Text = "";
                    break;
                case 4:
                    situationLabel.Text = "You head into the woods but throughout your journey you trip and end up falling for what seems like miles down a steep hill. You land on an unnfortunately pointy pile of rocks. Your injuries are too extensive and you slowly accept your death. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 5:
                    situationLabel.Text = "You get to highground and spot the front end of the plane a while down the beach to your right. Then to your left a few miles down, smoke is emerging from just inside the woods. The smoke is thick but you can tell it's coming from the tail end of the plane, you go...";
                    aOutputLabel.Text = "Straight to the front end of the plane."; //goes to scene 9
                    bOutputLabel.Text = "Continue up the mountain, the plane could still explode. It's much safer to keep your distance."; //goes to scene 10
                    cOutputLabel.Text = "Head to the tail."; //goes to scene 11
                    break;
                case 6:
                    situationLabel.Text = "You get to the tree and want food soon, you...";
                    aOutputLabel.Text = "Climb the tree in hopes to pick the coconuts."; //goes to scene 53
                    bOutputLabel.Text = "Shake the tree from the bottom so the coconuts fall to the ground."; //goes to scene 54
                    cOutputLabel.Text = "";
                    break;
                case 7:
                    situationLabel.Text = "You start to help a flight attendant who has an injury to her leg. She tells you that in crash situation such as this one, it usually takes a couple of hours for rescue troops to come and save the survivors. You think the best thing to do is... ";
                    aOutputLabel.Text = "Find the pilot, you need more information and she's the one who will have the most. "; //goes to scene 12
                    bOutputLabel.Text = "Go to find more resources you may be here for a while, you'll need more water and food."; //goes to scene 13
                    cOutputLabel.Text = "Trust someone's coming, stand look out for incoming boats and planes."; //goes to scene 14 
                    break;
                case 8:
                    situationLabel.Text = "You finally have a minute to relax in the cool ocean water, right up until a large wave and a strong undertow take you far from safety of the land, you eventually drown and die. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 9:
                    situationLabel.Text = "As soon as you get to the front end of the plane the first thing you see is a first aid kit and you can vaguely hear people screaming down the beach, you...";
                    aOutputLabel.Text = "Grab the first aid kit and follow the screams down the beach to go help the injured."; //goes to scene 15
                    bOutputLabel.Text = "Continue to investigate the front end of the plane."; //goes to scene 16
                    cOutputLabel.Text = "";
                    break;
                case 10:
                    situationLabel.Text = "You continue up the mountain though, you are dehydrated so you slip and fall all th way down the rocky cliff to your ultimate death. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 11:
                    situationLabel.Text = "You are on your way to the smoking tail when you pass by many people who are injured, you...";
                    aOutputLabel.Text = "Stop to try and help the people."; //goes to scene 17
                    bOutputLabel.Text = "Continue to the tail."; //goes to scene 18
                    cOutputLabel.Text = "";
                    break;
                case 12:
                    situationLabel.Text = "After further search You discover that the pilot is dead, but a few feet away you see someone who could be the copilot. He doesn't look like he is in much better shape than the pilot, but you check his pulse anyways. It's weak, but it's there, he is still alive, you choose to ";
                    aOutputLabel.Text = "Try to save him, he will know as much as the pilot did."; //goes to scene 19
                    bOutputLabel.Text = "Know you don't have enough medical knowledge to save him and think you might end up injuring him further. You should try something else."; //goes to scene 20
                    cOutputLabel.Text = "";
                    break;
                case 13:
                    situationLabel.Text = "As you are looking for some resources you see a large amount of smoke coming form a while down the beach just inside the woods, probably part of the plane, you...";
                    aOutputLabel.Text = "Go to the smoke, the plane will have so much to offer."; //goes to scene 21
                    bOutputLabel.Text = "Smoke means fire, you stay put and begin to rumage through the bags."; //goes to scene 22
                    cOutputLabel.Text = "";
                    break;
                case 14:
                    situationLabel.Text = "It's been several hours and no one has come, it's now starting to get dark, you...";
                    aOutputLabel.Text = "Start to make a fire."; //goes to scene 23
                    bOutputLabel.Text = "Try to find some food."; //goes to scene 24
                    cOutputLabel.Text = "Go to find somewhere safe and sheltered in the forest where you can sleep."; //goes to scene 25
                    break;
                case 15:
                    situationLabel.Text = "You get to the other survivors, but become overwhelmed by all the injury and disaster, you...";
                    aOutputLabel.Text = "Hand the first aid kit to someone more qualified to help, then go for a walk on your own to calm yourself down."; //goes to scene 26
                    bOutputLabel.Text = "Ask someone to fix up your arm before you begin to help the others."; //goes to scene 27
                    cOutputLabel.Text = "Power through and start to help right away."; //goes to scene 28
                    break;
                case 16:
                    situationLabel.Text = "You finally come across what appears to be a stationary transmitter, but you have no knowledge on technology and don't know what to do, you...";
                    aOutputLabel.Text = "Run to the people on the beach to get help, someone there must know what to do."; //goes to scene 29
                    bOutputLabel.Text = "Try to figure it out on your own, it can't be that hard."; //goes to scene 30
                    cOutputLabel.Text = "Keep searching the cockpit."; //goes to scene 31
                    break;
                case 17:
                    situationLabel.Text = "You begin helping a man who is concerned as his dog was on the plane as well. He begs you to help find the dog. He tells you how special this dog is to him and informs you she is adventurous, so she's probably in the woods and she goes by the name Zuza. You tell him...";
                    aOutputLabel.Text = "You will absolutely try and help so you head into the woods. "; //goes to scene 32
                    bOutputLabel.Text = "You are very sorry but there probably isn't much you can do."; //goes to scene 33
                    cOutputLabel.Text = "";
                    break;
                case 18:
                    situationLabel.Text = "You arrive at the tail and precariously search it. You find a flare gun with only one flare. If you fire now there is a 65% chance of someone spotting the flare or you could wait until nightfall which brings many other dangers, though, there is then an 85% chance of someone spotting your flare. You choose to...";
                    aOutputLabel.Text = "Fire now, you have to get off the island."; //chance either goes to scene 34 or 35
                    bOutputLabel.Text = "Wait until night fall, you only have one shot at this."; //goes to scene 36
                    cOutputLabel.Text = "";
                    break;
                case 19:
                    situationLabel.Text = "You have now been on the beach for a long time you realize you are extremely thirsty and are worried of dehydration and heat stroke. You think it's best to... ";
                    aOutputLabel.Text = "Search through the bags there must be some bottled water."; //goes to scene 37
                    bOutputLabel.Text = "Go into the woods there's probably fresh water somewhere."; // goes to scene 38
                    cOutputLabel.Text = "Head to the ocean, it's closest and you're desperate."; //goes to scene 39
                    break;
                case 20:
                    situationLabel.Text = "After a while, he regains consciousness and informs you that all the planes in their airline are equipped with a flare gun in the tail and a stationary transmitter in the cockpit. He also tells you that right as the plane went down you were flying over a section of small islands in the pacific that have civilization. You think the most logical thing to look for is... ";
                    aOutputLabel.Text = "The transmitter in the cockpit, so you can contact rescue."; //goes to scene 40
                    bOutputLabel.Text = "Civilization, we need people."; //goes to scene 41
                    cOutputLabel.Text = "The flare gun in the tail, someone will see a flare."; //goes to scene 42
                    break;
                case 21:
                    situationLabel.Text = "You precariously search what you believe to be the tail end of the plane, eventually finding a flare gun, but only one flare. You could fire now with a 65% chance of someone spotting the flare or you could wait until nightfall which brings many other dangers, though there is then an 85% chance of someone spotting your flare, you...";
                    aOutputLabel.Text = "Fire now, you have to get off the island."; //chance goes to scene 43 or 44
                    bOutputLabel.Text = "Wait until night fall, you only have one shot at this."; //goes to scene 45
                    cOutputLabel.Text = "";
                    break;
                case 22:
                    situationLabel.Text = "There are so many bags, you start with...";
                    aOutputLabel.Text = "A pink bag."; //goes to scene 46
                    bOutputLabel.Text = "A blue bag."; //goes to scene 47
                    cOutputLabel.Text = "A black bag."; //goes to scene 48
                    break;
                case 23:
                    situationLabel.Text = "You already have a lighter that is functional, now you just need something to burn, the best option is to...";
                    aOutputLabel.Text = "Go into the forest to get some wood"; //goes to scene 49
                    bOutputLabel.Text = "Stay on the beach, it's getting dark and you think the woods are too dangerous. You can try to burn the resources you can find on the beach such as odd items or branches. "; //goes to scene 50
                    cOutputLabel.Text = "";
                    break;
                case 24:
                    situationLabel.Text = "You think you could fish, though you also realize some berry bushes and a few coconut trees at the edge of the forest, your first pick is...";
                    aOutputLabel.Text = "Fishing."; //goes to scene 51
                    bOutputLabel.Text = "Berries."; //goes to scene 52
                    cOutputLabel.Text = "Coconuts."; //goes to scene 6
                    break;
                case 25:
                    situationLabel.Text = "When roaming the forest you come across what seems to be a dog barking and running back and forth. You don't think she's wild but there's no garuntee, you...";
                    aOutputLabel.Text = "Approach the dog, try to tame it and get a better look."; //goes to scene 55
                    bOutputLabel.Text = "Leave it and head back to the beach."; //goes to scene 56
                    cOutputLabel.Text = "";
                    break;
                case 26:
                    situationLabel.Text = "As you go for your lonely, calming walk you encounter a very large animal and are mangled minutes later, uh oh. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 27:
                    situationLabel.Text = "Unfortunately the person trying to help you is almost as unqualified as you are when it comes to medicine. They make some vital, deathly, mistakes. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 28:
                    situationLabel.Text = "The lady you are helping tells you of her severe plane crash phobia. You start to pay attention when she tells you she always keeps a portable transmitter in her blue carry on. After searching through what seemed like a million blue suitcases, you find the right bag. The transmitter is straght forward and still in tack. You recieve a signal and rescue comes two hours later. Congratulations, you save yourself and many others. Would yu like to play again?";
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 29:
                    situationLabel.Text = "You are able to locate a flight attendant with an injured leg on the beach. You convince her to come to the cockpit by telling her that you will fix her up with the supplies from the first aid kit. When you get there, together you successfully run the transmitter, recieve a signal and rescue comes two hours later. Congratulations, you saved yourself and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 30:
                    situationLabel.Text = "You get frustrated pretty quickly making a vital mistake and electrocuting yourself, a real shocker. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 31:
                    situationLabel.Text = "You continue to search the cockpit for indicators, instructions or anything that would help with the maintnance of the transmitter. After awhile you locate an instruction manual and get the transmitter to work all by yourself, you recieve a signal and rescue troops arrive two hours later. Congratulations, you saved yourself and many others. Wwould you like to play again?"; //Success
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 32:
                    situationLabel.Text = "You are in the woods calling for Zuza when you hear a distant barking. You get excited when you spot a German shepard, when it begins to run you follow it all the way to a small town. The people explain you are on an island called Pitcairn, located in the middle of the Pacific. Congratulations, you and Zuza saved yourselves and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 33:
                    situationLabel.Text = "You begin to walk away from the man when you step on a large cobra. Unfortunately the large snake is not forgiving, it bites you, you die. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 34:
                    situationLabel.Text = "Your flare goes unnoticed but it does clip a tree which causes a large forest fire to igniting the remainder of the tail and causing large explosion killing you and many other of the remaining survivors are blown to smitherines. You went out with a bang. Would you like to play again."; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 35:
                    situationLabel.Text = "A boat was just close enough to notice your flare. They notify search and rescue, who come within just a few hours. Congratulations you saved yourself and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes.";
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 36:
                    situationLabel.Text = "It is now night time, you are ready to fire your flare and because you only have one chance and you need to concentrate. Just as you are about to shoot, a large animal burst out of the bushes and is now coming at you, you approach the situation by...";
                    aOutputLabel.Text = "Go on offense, grab a near by branch and attack."; //goes to scene 57
                    bOutputLabel.Text = "Screaming."; // goes to scene 58
                    cOutputLabel.Text = "";
                    break;
                case 37:
                    situationLabel.Text = "You are unable to find the water quick enough, you pass out because of dehydration. No one helps you, then you die. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 38:
                    situationLabel.Text = "You find water in the forest, it is so glorious you decide to rinse off but the current is strong and then, oh no, water fall ahead there is no way to escape. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 39:
                    situationLabel.Text = "It's salt water, you drink to much, making you sick and bringing you death. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 40:
                    situationLabel.Text = "after searching you are able to find the frontend of the plane where you locate the transmitter. Too bad it was getting dark and had no knowledge in technology, you get frustrated ending in electrocution. Would you like to play agian?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 41:
                    situationLabel.Text = "You start to walk around the beach but it gets dark fast and you are now very far from the other survivors. You are now tired so you try to sleep by the edge of a the small mountain, unfortunately, large falling rocks crush you in your sleep. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes.";
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 42:
                    situationLabel.Text = "Because of the large amount of smoke coming from the back end of the plane you are able to locate the tail and with that, the flare gun. There is only one small problem you only have one flare. Because it's now dark out there is an 85% chance that your flare will be seen, you fire the flare.";
                    aOutputLabel.Text = "Ok."; //chance either goes to scene 59 or 60
                    bOutputLabel.Text = "";
                    cOutputLabel.Text = "";
                    break;
                case 43:
                    situationLabel.Text = "Your flare goes unnoticed but it does clip a tree which causes a large forest fire, igniting the remainder of the tail and causing a large explosion. Blowing you and many other survivors to smitherines. Atleast you went out with a bang. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 44:
                    situationLabel.Text = "Someone in a low flying plane notices your flare. Rescue arrives a few hours later. Congratulations, you ahve saved yourself and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 45:
                    situationLabel.Text = "It's now night time, you are ready to fire your flare and because you only have one chance and you need to concentrate. Just as you are about to shoot, a large animal burst out of the bushes and is now coming at you, you approach the situation by...";
                    aOutputLabel.Text = "Go on offense, grab a near by branch and attack."; //goes to scene 61
                    bOutputLabel.Text = "Screaming."; //goes to scene 62
                    cOutputLabel.Text = "";
                    break;
                case 46:
                    situationLabel.Text = "Several scorpions crawl out of the bag and bite you, it only takes a few hours for the poisson to kick in. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 47:
                    situationLabel.Text = "You find no food or water but you do find a portable transmitter in full function. The transmitter is straght forward and still in tack. You recieve a signal and rescue comes two hours later. Congratulations, you save yourself and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 48:
                    situationLabel.Text = "";
                    aOutputLabel.Text = "Yes.";
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 49:
                    situationLabel.Text = "You head to the edge of the forest and manage to gather up a fair amount of wood and kindling, luckily you make it back before it's completely dark so you don't get lost. You are able to successfully start a large fire. Large enough to signal a low flying plane who then informs search and rescue. They arrive a few hours later. Congratulations, you save yourself and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 50:
                    situationLabel.Text = "Unfortunately the items you chose to burn were covered in fuel which then got on your hands, when you try to light, you are the one who sets on fire. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes.";
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 51:
                    situationLabel.Text = "Unfortunately you catch something too big and it drags you in. Atleast someone got a snack. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 52:
                    situationLabel.Text = "Too bad those berries you just ate were poissoned. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 53:
                    situationLabel.Text = "You try to climb the tree but end up falling and landing on a rock. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 54:
                    situationLabel.Text = "A large bunch of coconuts come crashing down on your head, you suffer major brain damage. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes.";
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 55:
                    situationLabel.Text = "The dog is calm and appears to have a collar. Her name appears to be Zuza, you assume that she belonged to a passenger on the plane so when she runs, you follow her. After what seems to have been miles of running you realize she has brough you to civilization. Congratulations, you and Zuza have saved yourselves and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 56:
                    situationLabel.Text = "You don't get out of the woods before nightfall then you are lost alone and you fall into a large pit, trapping you indeffinetly. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 57:
                    situationLabel.Text = "You are no match to the beast and you are violently killed and mangled. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 58:
                    situationLabel.Text = "The animal becomes frightened and runs back into the bushes you then fire the flare.";
                    aOutputLabel.Text = "Ok."; //chance either goes to scene 63 or 64
                    bOutputLabel.Text = "";
                    cOutputLabel.Text = "";
                    break;
                case 59:
                    situationLabel.Text = "Your flare goes unseen and a raging storm hits the beach during the night, you are struck by lightning. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 60:
                    situationLabel.Text = "Your flare is spotted by someone out boating, rescue comes a few hours later. Congratulations, you save yourself and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes.";
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 61:
                    situationLabel.Text = "You are no match to the beast and you are violently killed and mangled. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 62:
                    situationLabel.Text = "The animal becomes frightened and runs back into the bushes you then fire the flare.";
                    aOutputLabel.Text = "Ok."; //chance either goes to scene 65 or 66
                    bOutputLabel.Text = "";
                    cOutputLabel.Text = "";
                    break;
                case 63:
                    situationLabel.Text = "No one notices the flare, a raging storm hits the beach during the night, you are struck by lightning. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 64:
                    situationLabel.Text = "You fire the flare and someone spots your signal from a plane. Rescue comes a few hours later. Congratulations, you save yourself and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 65:
                    situationLabel.Text = "No one notices the flare a raging storm hits the beach during the night, you are struck by lightning. Would you like to play again?"; //Death
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;
                case 66:
                    situationLabel.Text = "You fire the flare and someone spots your signal from a plane. Rescue comes a few hours later. Congratulations, you have saved yourself and many others. Would you like to play again?"; //Success
                    aOutputLabel.Text = "Yes."; 
                    bOutputLabel.Text = "No.";
                    cOutputLabel.Text = "";
                    break;

            }
        }
    }
}
    
