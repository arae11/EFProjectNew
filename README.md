# ReadMe

## Project Goal
- Have a WPF Front End
- Have and SQL database backend with at least two linked tables
- Use Entity Framework to manage the relationship between your backend object model and database
- Have a Business Layer with some logic

**Create an application that stimulates your short term memory and stores the scores, allowing you to track your progress.**

## Definition of Done
- Code has been written
- Code has been tested
- Ensure code is compliant with user story requirement
- Acceptance criteria has been met
- Code has been documented and pushed to GitHub

## Class Diagrams
![class diagram](https://user-images.githubusercontent.com/60930006/130411392-e273b491-e131-42a4-b12d-a02b17fea4e6.png)
![class diagram2](https://user-images.githubusercontent.com/60930006/130411609-85188f25-4618-4722-9272-2ea69171783a.png)


## Project Retrospective
- I think the overall process of the project went well.
- If I were to change my approach for the future I would have aimed to do the database content after the front-end.
> - This is because I had made errors when migrating the data initially so I had to remigrate and create the database several times over before I got it to work.
> - This would be important in a work environment as I was unable to provide a completed increment at the end of the sprint because of this.
- I think if I had more time beforehand to experience and experiment with WPF I would have been able to code the front-end a lot faster
> - At the end of the UI development during the last sprint I felt very comfortable with the commands and XAML in general. This would have been beneficial at the start of the project.
- Although I achieved the MVP I would have liked to have implemented the addition games I had formulated in my notes.
> - If I had made the changes mentioned above I likely would have had enough time to implement at least one of the additional games.
- I also would have liked to alter the leaderboard slightly as the column contents are not centred and there is not column displaying the difficulty of game the user had achieved the score at.

## Sprint Summaries

### Sprint 1
#### Sprint Goal
- Create the database and link the files together.
- Implement the user login system.

#### Backlog Items Completed
- None fully implemented.

#### Sprint Retrospective
- Re-evaluated the task criteria and changed the project towards the end of sprint in order to fully meet the criteria.
- This meant that most of the sprint was wasted trying to remake the project.
- Most of the databases have been created and linked.

#### Sprint Board
> - Before: 
> ![Sprint 1 start](https://user-images.githubusercontent.com/60930006/130409259-8cfcc4ba-c98a-4df8-994f-34e0aeb05111.png)
> - After: 
> ![sprint 1 end](https://user-images.githubusercontent.com/60930006/130409351-eee78f3d-aa6b-4848-8115-204beecc3fa2.png)

### Sprint 2
#### Sprint Goal
- Finish creating the database.
- Finish the user login and account system.
- Ensure users registered are unique.

#### Backlog Items Completed
- Epic coded - Create a user login and account system.
  > - User can register new accounts with a username and password.
  > - Usernames must be unique.
  > - Users are stored in the User table.

- Epic coded - Create a database to store user's scores.
  > - User's scores are stored in the Scores table.
  > - A User can view the latest score they achieved.
  > - A User can view the highest score they have achieved.

#### Sprint Retrospective
- Luckily the login feature that I had started developing in sprint 1 was usable in the second sprint. This provided me with a foundation to store user scores.
- I have completed the entire backend, allowing me to start implementing it in the business layer.
- The tasks have been moved to review as the code to test it hasn't been completed yet.

#### Sprint Board
> - Before: 
> ![sprint 2 start](https://user-images.githubusercontent.com/60930006/130409407-1924de9c-9388-406a-ae94-8e2cb6ef70fb.png)
> - After: 
> ![sprint 2 end](https://user-images.githubusercontent.com/60930006/130409452-df2bf4b0-a27c-4032-9ad6-b7e80b2b349b.png)


### Sprint 3
#### Sprint Goal
- Create the first memory game to achieve the MVP.

#### Backlog Items Completed
- The main functionality of the game has been completed.
  > - The user will gain score for the correct answer and lose lives for the incorrect answer.
  > - When the game is over the user is taken to the leaderboard.

#### Sprint Retrospective
- Although the current UI is very basic the game is working as intended.
- Adding the score to the relevant User hasn't been implemented yet however.
- When taken to the leaderboard nothing is displayed.

#### Sprint Board
> - Before: 
>![sprint 3 start](https://user-images.githubusercontent.com/60930006/130409518-79a5a86c-6b0e-44fa-9bc4-274ebaafa6d8.png)
> - After: 
> ![sprint 3 end](https://user-images.githubusercontent.com/60930006/130409552-19eba418-c214-4034-a4ad-bba4dde0dabf.png)


### Sprint 4
#### Sprint Goal
- Implement the score saving according to the user and display it in the leaderboard.
- Create a second difficulty for the memory game.

#### Backlog Items Completed
- Code has been completed for the second difficulty.
- Functionality of the leaderboard has been completed.

#### Sprint Retrospective
- Leaderboard is correctly showing the intended information however there is zero frontend completed for it making it currently unusable.

#### Sprint Board
> - Before: 
> ![![sprint 4 start](https://user-images.githubusercontent.com/60930006/130409654-c79d4a41-8a18-4ea2-b2e4-e83af30f8eab.png)
> - After: 
> ![sprint 4 end](https://user-images.githubusercontent.com/60930006/130409689-eac75cf4-45da-4984-a650-98a9d50177a0.png)


### Sprint 5
#### Sprint Goal
- Make the leaderboard show the correct information and ensure it is readable.
- Make the leaderboard show the most recent score a user has achieved.
- Make the leaderboard show the highest score a user has achieved.

#### Backlog Items Completed
- Leaderboard is now fully functional and usable.
- Leaderboard shows Username, Latest Score and High Score.

#### Sprint Retrospective
- The MVP of the product has been completed.
- Ideally I would have liked to add another column that indicated which difficulty the user achieved the score at
  > Not sure if this is relevant as I don't know if it is harder to recall longer words compared to short words.
- I would have liked to implement the extra user stories but as there is only one sprint left there is not enough time.
- The final sprint will allow me to overhaul the front end and make it a usable product.

#### Sprint Board
> - Before: 
> ![sprint 5 start](https://user-images.githubusercontent.com/60930006/130409732-42c1850a-ab3b-45ca-a08f-fe39f3f195bb.png)
> - After: 
> ![sprint 5 end](https://user-images.githubusercontent.com/60930006/130409759-3f53bbe4-d3fd-4166-8080-7fd9fb19f724.png)


### Sprint 6
#### Sprint Goal
- Redesign the front-end to make the product presentable for a hypothetical customer.

#### Backlog Items Completed
- Completed design overhaul

#### Sprint Retrospective
- I decided to change the dimensions of the app to better fit a small screen such as a phone.
  > - This decision was made because of the simplicity of the UI and overall game
  > - Having it spread out across an entire monitor overemphasised the empty space which is why the smaller form factor fit better.
- The only thing I would have liked to improve in this aspect was the centring of the contents in the leaderboard
  > The column headers are centred however the contents are not. I spent hours trying to fix this but could not find a solution.

#### Sprint Board
> - Before: 
> ![sprint 6 start](https://user-images.githubusercontent.com/60930006/130409798-9ecde650-aa08-4f5c-90ae-f35f51a1eb1a.png)
> - After: 
> ![sprint 6 end](https://user-images.githubusercontent.com/60930006/130409831-8bb37328-7b11-4c34-a053-26c288fd24ae.png)
