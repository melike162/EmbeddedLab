# STM32 to MySQL: UART-Based Analog Data Logger

This project demonstrates **analog data acquisition** using an **STM32F407VGT6** microcontroller and a **C# Windows Forms** interface. Data is transmitted via **UART**, stored in a **MySQL database**, and visualized using **ScottPlot**.  

## Project Contents

**STM32 CubeIDE Code (`real_time_logger_cubeide`)**  
- Reads 2 channels using **ADC1** (e.g., Light sensor and Potentiometer).  
- ADC values are continuously read using **DMA**.  
- Values are sent over **UART** in the following format: `123;456\r\n`  
- STM32 sends data every 500 ms (`HAL_Delay(500)`).

**C# Windows Forms Interface (`real_time_logger_c`)**  
- Single-screen interface  
  - COM port and baud rate selection  
  - MySQL database connection  
  - Receives UART data and inserts it into the database  
  - Displays data in **DataGridView**  
  - Plots data in real-time using **ScottPlot**  
- Libraries used: `ScottPlot 5.0.56`, `MySql.Data 9.4.0`  

## Requirements

- **STM32 CubeIDE** and STM32F407G DISC1 (or equivalent)  
- **Visual Studio 2022** or newer  
- USB-UART cable or STM32 virtual COM port  
- **MySQL Server**  
- **.NET Framework 4.7.2** or newer  

## Usage

**STM32**  
1. Build and flash the project using CubeIDE.  
2. Connect the STM32 board to your PC.  

**C# Interface**  
1. Open the project in Visual Studio and build it.  
2. Select the COM port and baud rate, then click **Connect**.  
3. Select a table and click **Write** to start saving incoming data to the database.  
4. Data will be displayed in the **DataGridView** and plotted using ScottPlot.  

## Database Structure and Data

- Table structure:  
| id (INT) | sensor1 (INT) | sensor2 (INT) | time (TIMESTAMP) |  
|-----------|---------------|---------------|-----------------|  
| 1         | 123           | 456           | 2025-10-03 11:32:01 |  
| 2         | 125           | 458           | 2025-10-03 11:32:02 |  

- `sensor1` → First ADC value from STM32 (e.g., Light sensor)  
- `sensor2` → Second ADC value from STM32 (e.g., Potentiometer)  
- `time` → Timestamp of the data  

STM32 sends data as `sensor1;sensor2\r\n`, which the C# application parses and inserts into the database.  

## Notes

- **MySql.Data 9.4.0** must be installed via NuGet.  
- **ScottPlot 5.0.56** is used for real-time plotting.  
- Data is transmitted from STM32 every 500 ms; this interval can be adjusted in the code.  
