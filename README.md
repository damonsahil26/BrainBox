# Brainbox - Real-Time Quiz Application

Brainbox is a real-time quiz application built using .NET 8 for the backend, SignalR for real-time communication, and Razor Pages for the user interface. The application allows users to participate in quizzes, view their scores, and compete with others in real time. This application is designed to provide an engaging and interactive quiz experience.

## Features

- **Real-Time Communication**: Leveraging SignalR, users can participate in quizzes and see live updates.
- **User-Friendly UI**: Built using Razor Pages, the app offers a clean and intuitive interface.
- **Dynamic Quizzes**: Quizzes can be updated and managed in real time.
- **Scoring System**: Users can see their scores as they answer quiz questions.
- **No Admin Interface**: There is no admin page; quizzes are managed directly from the backend.

## Tech Stack

- **Backend**: .NET 8
- **Real-Time Communication**: SignalR
- **Frontend**: Razor Pages
- **Database**: MS SQL Server
  
## Installation

### Prerequisites

- .NET 8 SDK
- MS SQL Server
  
### Steps

1. Clone the repository:

    ```bash
    git clone https://github.com/damonsahil26/BrainBox.git
    cd brainbox
    ```

2. Set up the database:

    - Configure your database connection string in the `appsettings.json` file.

3. Install dependencies and run the application:

    ```bash
    dotnet restore
    dotnet build
    dotnet run
    ```

4. Open your browser and navigate to:

    ```
    https://localhost:5001
    ```

## SignalR Integration

SignalR is used for real-time updates during the quiz sessions. It enables features like live score updates and question syncing between users in real-time.

## Usage

- **Start a Quiz**: Users can join a quiz by navigating to the homepage and selecting a quiz.
- **Answer Questions**: Questions will be displayed in real-time. Users can submit their answers through the UI.
- **View Scores**: As users answer questions, their scores will be updated dynamically using SignalR.

## Folder Structure

```bash
Brainbox-Quiz-App/
│
├── BrainboxQuizApp.sln      # Solution file
├── Controllers/             # API Controllers for quiz logic
├── Pages/                   # Razor Pages for UI
├── Hubs/                    # SignalR hubs for real-time communication
├── Models/                  # Models for quiz, questions, and users
├── Services/                # Business logic and service classes
├── wwwroot/                 # Static files (CSS, JavaScript, etc.)
├── appsettings.json         # Configuration file
└── Program.cs               # Application entry point
