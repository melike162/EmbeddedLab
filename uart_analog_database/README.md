# STM32 to MySQL: UART-Based Analog Data Collector

This project demonstrates **analog data acquisition** using an **STM32F407VGT6** microcontroller and a **C# Windows Forms** interface. Data communication is done via **UART**.  

---

## 📁 Project Contents

### 1️⃣ STM32 CubeIDE Code (`analog_cubeide`)
- Reads 2 channels using **ADC1** (e.g., Light sensor and Potentiometer).  
- ADC values are continuously read using **DMA**.  
- The acquired values are sent in a formatted way over **UART2**.  
  **Example format:** `Light: 123   Pot: 456\r\n`

### 2️⃣ C# Windows Forms Interface (`analog_c`)
- **Form1:** Login screen for MySQL database connection  
  - Fields: Server, Database, Username, Password  
  - Checks for empty fields and opens Form2 upon successful login  
- **Form2:** Data acquisition screen  
  - **COM port** and **baud rate** selection  
  - Receives UART data from STM32 and optionally **writes it to the MySQL database**  
  - Displays received data in a **DataGridView**  
  - Connection management (Connect/Disconnect) and **Start/Stop Writing to Database** buttons

---

## ⚙️ Requirements

- **STM32 CubeIDE** and STM32F407G DISC1 (or equivalent board)  
- **Visual Studio 2022** or newer (for C# Windows Forms application)  
- USB-UART cable or STM32 built-in virtual COM port  
- **MySQL Server** database  
- **.NET Framework 4.7.2** or newer  

---

## 🚀 Usage

### STM32
1. Build and flash the project using CubeIDE.  
2. Connect the STM32 board to the computer.  

### C# Interface
1. Open and build the program in Visual Studio.  
2. Fill in the database connection fields and click **Login**.  
3. In Form2, select the COM port and baud rate, then click **Connect**.  
4. Click **Write to Database** to start saving incoming data to the database.  
5. The received analog values will be displayed in the DataGridView and saved to the database.

### ⚠️ Notes
- Ensure that **MySql.Data** is installed via NuGet; otherwise, database connectivity will fail.  
- PD12 LED is only used for testing and does not affect data collection.  
- Data is sent from STM32 once per second (`HAL_Delay(1000)`), adjust in code if needed.