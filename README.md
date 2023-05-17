<p align="center">
    <img src="https://i.imgur.com/qW5Udoj.png" alt="Logo" width="100">
    <h3 align="center">AirManager</h3>
    <br>
</p

**AirManager** is a comprehensive, user-friendly application designed to provide an efficient and straightforward solution for air ticketing and management. Written in **C# using Windows Forms with .NET Framework** and powered by **Microsoft Database**, the application offers a high level of functionality and reliability.

This is a school project done at the **Faculty of Cybernetics, Statistics, and Economic Informatics (CSIE)** within the **Bucharest University of Economic Studies (ASE)** for the subject of **Windows Application Programming (PAW)**.

# Application Features 💪

## 🔒 Secure Authentication
 AirManager implements a robust login and signup system with Two-Factor Authentication (2FA) for added security. User passwords are hashed and securely stored in the database.

## ✈️ **Admin and Passenger Interfaces**: 
 AirManager offers two distinct interfaces - one for administrators and another for passengers. The admin interface allows efficient management of airports, airlines, routes, flights, passengers, and reservations. The passenger interface enables users to purchase tickets and print them. 

## 🌐 Microsoft Database Integration
 The application utilizes Microsoft Database for efficient data storage and retrieval. This ensures a reliable and scalable foundation for managing various aspects of the airline industry. 

## 📧 Email Notifications
 AirManager includes the functionality to send verification and welcome emails to users. This feature enhances the user experience by providing timely and informative notifications. 

## ✅ Field Validations
 All input fields within the application are validated to ensure data integrity. For example, the email field validates the format as email@domain.com, ensuring accurate and valid email addresses.

## Usage 👀

### 🛠️ Admin Interface
The admin interface provides comprehensive management capabilities:

 - 🛫 **Airports**: Add, delete, and edit airports.
 - 🛩️ **Airlines**: Manage airline information, including adding, deleting, and editing airlines.
 - 🛤️ **Routes**: Create, modify, and delete routes for flights.
 - ✈️ **Flights**: Manage flight details, such as adding, deleting, and editing flight schedules.
 - 👤 **Passengers**: View and manage passenger information, including adding, deleting, and editing passenger profiles. 
 - 🎟️ **Reservations**: Handle reservations, including adding, deleting, and managing passenger bookings. 

### 🧳 Passenger Interface
The passenger interface allows users to purchase tickets and print them: 

 - 🎫 **Ticket Purchase**: Select desired flights, enter passenger details, and complete the ticket purchase process. 
 - 🖨️ **Ticket Printing**: Print purchased tickets for reference or travel purposes.

## Getting Started 📝
To run the AirManager application locally, follow these steps:
1. Clone the repository to your local machine.
2. Import database from DB folder.
3. Open the project in Visual Studio.
5. Configure the Microsoft Database connection settings.
6. Build and run the application.

## Dependencies 💻
The AirManager application relies on the following dependencies:
- Microsoft Database
- Windows Forms (part of .NET Framework)

Ensure that these dependencies are properly installed before running the application.

## License 🪪
This project is licensed under the [MIT License](LICENSE).
