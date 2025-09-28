# STM32 to PC: UART-Based LED Controller

This project demonstrates **LED control and data exchange** over **UART communication** using an **STM32F407VGT6** microcontroller and a **C# Windows Forms** interface.

---

## 📁 Project Contents

### 1️⃣ STM32 CubeIDE Code (`led_cubeide`)
- Communication is established via **UART4** between the STM32 and the PC.
- Incoming commands from the PC control the LEDs on the STM32 board:
  - `"1"` → Green LED (PD12) ON, sends back `"2"`
  - `"3"` → Orange LED (PD13) ON, sends back `"4"`
  - `"5"` → Red LED (PD14) ON, sends back `"6"`
  - `"7"` → Blue LED (PD15) ON, sends back `"8"`
- Previous LEDs are turned OFF when a new command is received.
- **UART interrupt** is used for continuous data reception.

### 2️⃣ C# Windows Forms Interface (`led_c`)
- Allows **COM port** and **baud rate** selection.
- Connection management via **Connect / Disconnect** buttons.
- Incoming UART data from STM32 is displayed in a **TextBox**.
- **LED control buttons** send commands to STM32:
  - LED1 → `"1"`
  - LED2 → `"3"`
  - LED3 → `"5"`
  - LED4 → `"7"`
- Response values from STM32 (e.g., `"2"`, `"4"`, `"6"`, `"8"`) are shown on screen.

---

## ⚙️ Requirements
- **STM32 CubeIDE** (or Keil uVision)  
- **STM32F407G DISC1** or an equivalent STM32 board  
- **Visual Studio 2022** (for C# Windows Forms application)  
- USB-UART converter or STM32’s built-in virtual COM port  
- **.NET Framework 4.7.2** or newer  

---

## 🚀 Usage

### STM32 Side
1. Build and flash the project to the STM32 board using CubeIDE.  
2. Make sure LEDs are connected to pins **PD12, PD13, PD14, PD15**.  
3. Connect the STM32 to your PC via USB.  

### C# Interface
1. Open and build the project in Visual Studio.  
2. Refresh and select the correct **COM port** and **baud rate**.  
3. Click **Connect** to establish the connection.  
4. Use **LED1–LED4** buttons to send commands to the STM32.  
5. Responses from STM32 will be displayed in the **TextBox**.
