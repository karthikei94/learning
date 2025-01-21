# CQRS Memento Application

This project implements the CQRS (Command Query Responsibility Segregation) pattern using the Memento pattern for managing text content. It includes an in-memory service bus for handling commands and queries.

## Project Structure

- **Application**
  - **Commands**
    - `SaveTextCommand.cs`: Command for saving text content.
  - **Queries**
    - `GetTextQuery.cs`: Query for retrieving text content.
  - **Services**
    - `TextService.cs`: Service for managing text content operations.

- **Domain**
  - **Entities**
    - `TextMemento.cs`: Represents a memento for storing text content.
  - **Interfaces**
    - `ITextRepository.cs`: Interface for text content repository.
  - **ValueObjects**
    - `TextContent.cs`: Encapsulates text content with validation logic.

- **Infrastructure**
  - **Persistence**
    - `TextRepository.cs`: Implements data storage and retrieval logic.
  - **ServiceBus**
    - `InMemoryServiceBus.cs`: Simulates a service bus for event handling.

- **Program.cs**: Entry point of the application, setting up the service bus and initializing the application.

## Getting Started

1. Clone the repository.
2. Navigate to the project directory.
3. Build the project using your preferred .NET CLI commands.
4. Run the application.

## Usage

- Use the `SaveTextCommand` to save text content.
- Use the `GetTextQuery` to retrieve saved text content.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or features.

## License

This project is licensed under the MIT License. See the LICENSE file for details.