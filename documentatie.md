Merge fellas (item dropper) - reference
https://www.youtube.com/watch?v=j9AJb43uITI

Merge fellas clone - Game Description

#. Players drop fellas from top to bottom
#. Merging happens automatically when two fellas of the same level collide. After each merge, the old fella disappears and a new one (with a higher level) appears
#. The game ends when there is no more space at the top for new fellas
#. 2 game modes both 3 levels: kickboxing & muay thai 


Game Structure
	1. classes
		a.The fellas/items {it goes from 1st to the 5th fellas in an random order}
			items muay thai: Nam Nam Oil, prajead & mongkol, handwraps, elbow protectors, wai kru, boxing gloves, shin guard, thaipad, puching bags, boxing ring 
			items kickboxing: nam nam oil, ankle sock, handwraps, boxing gloves, shin guard, thaipad, puching bags, boxing ring 

		b.Game modes, kickboxing & muay thai
		c.Levels there are 3 levels for both game modes:
			easy: no timer for when the item has to drop 
			meduim: you get 5 seconds to drop the item else the timer runs out and it wil be dropped on where the dropper is located
			hard: you get 3 seconds before the item drops else it wil be dropped on where the dropper is located

		d.The dropper {An indicator that drops the fellas, with a red beam/line showing where it will drop} 
		e.Movement {make sure the fellas falls when dropped & moves on the ground to the left or the right} 
		f.Upgrade/merge {when 2 same fellas touch they merge & upgrade in to 1 bigger fella}
		g.Explosion {when 2 same fellas touch they make a small explosion}
		h.Sounds? (when the last item is merged you hear a applaud)
		i.Scoring system/display

	2.frontend/display
		a.black background with a green box like shape (no top) to show how far the fellas can go (when the fellas go out of the box its a automatic end game)
		b.I need a start screen with the 5 highest score by who that did (from the database) 
		c.End screen with your score + name (from the database) option to start a new game or go to the startscreen
		d.next to the box a leveling display from the fellas
		e.What are the fellas + what are they upgrading into

	3.Database
		a.database connection
		b.playername + score row
		c.The fellas row

Daily Activity
	24-05-2025
		We’ve started with the first bits of the documentation — some ideas about what I want, how I imagine the game, and a rough plan for the database. Still early days though, and there’s a lot I’m not 100% sure about yet. 

	06-06-2025
		I’ve made a start on the wireframes — the levels and level display are already done, and I’ve picked what the fellas/items will be. I also came up with a fun idea to add some extra levels, 3 to be precise: easy, meduim & hard.
Code instructions
A detailed explanation of the functionality and logic behind the code
trello