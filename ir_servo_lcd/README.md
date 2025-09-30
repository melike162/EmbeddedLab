# 🚪 STM32 IR-Controlled Password Door Lock with LCD Display

This project demonstrates a **password-protected door lock system** using the **STM32F407VGT6** microcontroller.  
The system uses an **IR remote** to input a 4-digit password, controls a **servo motor** to open/close the door, and displays status messages on an **LCD**.

---

## 📁 Project Features

### 1️⃣ Input and Actuators
- **IR Remote Receiver:** Receives input from an IR remote (TIM3 Input Capture)  
- **Servo Motor:** Controlled via **TIM1 PWM** channel 1 to open/close the door  
- **LED Indicator:** LED turns on when the door is opening and off when closing (GPIOD PIN12)  

### 2️⃣ Display
- **LCD Display:** Shows greeting messages, password entry progress, and success/failure messages  

**LCD Pins:**

| LCD Pin | Connection |
|---------|------------|
| VSS     | GND        |
| VDD     | 5V         |
| V0      | Pot middle pin (for contrast) |
| RS      | PA1        |
| RW      | PA2        |
| E       | PA3        |
| D4      | PA4        |
| D5      | PA5        |
| D6      | PA6        |
| D7      | PA7        |

### 3️⃣ Timers
- **TIM1:** PWM for servo motor control  
- **TIM2:** Timer used for LCD updates or delays  
- **TIM3:** Input Capture for decoding IR signals  

---

## ⚙️ STM32 Initialization

- **GPIO:**
  - LED and LCD pins configured as `GPIO_MODE_OUTPUT_PP`  
  - IR input connected to TIM3 Input Capture pin  
- **Timers:**  
  - TIM1 for PWM output to servo  
  - TIM2 as basic timer  
  - TIM3 configured for input capture and interrupt on rising edge  
- **HAL Library** used for initialization and peripheral handling  

---

## 🚀 Program Flow

### 1️⃣ Startup
- LCD displays `"Login password"` message  
- Waits for user input via IR remote  

### 2️⃣ Main Loop
- Reads IR signals via TIM3 input capture  
- Decodes 32-bit IR data into button numbers  
- Accepts up to **4 digits** as password input  
- Displays remaining digits on the LCD  

### 3️⃣ Password Check
- If 4 digits are entered:  
  - Compares with predefined password (`0,1,2,3`)  
  - **Correct password:**  
    - Displays `"Correct password"`  
    - Opens door (servo PWM 50), LED on  
    - Waits, then closes door (servo PWM 100), LED off  
    - Returns LCD to `"Login password"`  
  - **Incorrect password:**  
    - Displays `"Wrong password"`  
    - Resets input  

---

## 🔧 Custom Functions

- `int IR_GetButtonNumber(uint32_t receivedData)`  
  - Maps received 32-bit IR code to button numbers  

- `void uint32_to_hex(uint32_t data, uint8_t *pData)`  
  - Converts 32-bit IR data to hex string for debugging/logging  

---

## ⚠️ Notes

- Ensure **IR receiver** is connected to the correct TIM3 input pin  
- PWM duty cycle values may need adjustment for your servo:  
  - 50 = Open, 100 = Close, 75 = Stop  
- LCD library (`lcd.h`) must be included and correctly configured  
- LED and servo GPIO pins can be adjusted in `MX_GPIO_Init()` if needed  

---

## 📦 Hardware Connections

| Component      | STM32 Pin       |
|----------------|----------------|
| IR Receiver    | TIM3 CH1 (GPIO pin) |
| Servo PWM      | TIM1 CH1        |
| LED Indicator  | GPIOD PIN12     |
| LCD            | See LCD Pins table above |
| Potentiometer  | LCD V0 pin      |

---

## ⚡ Requirements

- **STM32F407VGT6** or equivalent board  
- **HAL library** for STM32  
- **LCD library** (`lcd.h`) included in project  
- Servo motor compatible with PWM  
- IR receiver module  
- LED (optional for indication)
