# cqrs-memento-app

This project implements the CQRS (Command Query Responsibility Segregation) pattern using the Memento pattern for state management. It includes an in-memory service bus for handling commands and queries.

## Project Structure

- **src**
  - **Application**
    - **Commands**
      - `SaveTextCommand.cs`: Command to save text content.
    - **Queries**
      - `GetTextQuery.cs`: Query to retrieve text content.
    - **Services**
      - `TextService.cs`: Service for saving and retrieving text content.
  - **Domain**
    - **Entities**
      - `TextMemento.cs`: Represents a memento for storing text content.
    - **Interfaces**
      - `ITextRepository.cs`: Interface for text content repository.
    - **ValueObjects**
      - `TextContent.cs`: Encapsulates text content with potential validation.
  - **Infrastructure**
    - **Persistence**
      - `TextRepository.cs`: Implements the text repository interface for data storage.
    - **ServiceBus**
      - `InMemoryServiceBus.cs`: Simulates a service bus for message handling.
  - `Program.cs`: Entry point of the application, sets up the service bus and initializes the application.

## Getting Started

1. Clone the repository.
2. Navigate to the project directory.
3. Build the project using your preferred .NET build tool.
4. Run the application.

## Usage

- Use the `SaveTextCommand` to save text content.
- Use the `GetTextQuery` to retrieve saved text content.

## Contributing

Contributions are welcome! Please submit a pull request or open an issue for discussion.