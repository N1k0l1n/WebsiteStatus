# Website Status Checker

This project is a .NET worker service that checks the status of a website at regular intervals and logs the status to a file.

## Description

The `WebsiteStatus` project contains a worker service that periodically sends an HTTP request to a specified website and logs whether the website is up or down. It uses Serilog for logging and is designed to run as a background service.

## Features

- Uses HttpClient to check the status of a website.
- Logs the website status to a file using Serilog.
- Built using .NET.

## Usage

To use this project:

1. Clone this repository.
2. Update the `Worker.cs` file in the `WebsiteStatus` project to specify the website you want to check.
3. Build and run the project.
4. Check the log file for the status of the website.

## Setup

To run the project:

1. Make sure you have .NET SDK installed.
2. Open the solution in your preferred IDE (Visual Studio, Visual Studio Code, etc.).
3. Update the website URL in the `Worker.cs` file to the desired URL.
4. Build and run the project.

## Dependencies

- .NET SDK
- Serilog
- HttpClient

## Contributing

Contributions are welcome! Feel free to fork this repository and submit pull requests.

## License

This project is licensed under the [MIT License](LICENSE).
