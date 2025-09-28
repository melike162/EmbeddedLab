# STM32 Door Control with PIR Sensor and LCD Display

This project demonstrates **automatic door control** using the **STM32F407VGT6** microcontroller. The system uses a **PIR motion sensor** to detect movement, controls a **servo motor** to open/close the door, and displays messages and counters on an **LCD**.

---

## 📁 Project Features

### 1️⃣ Sensors and Actuators
- **PIR Sensor:** Detects motion (GPIOA PIN0)  
- **Servo Motor:** Controlled via **TIM1 PWM** channel 1  
- **LED Indicator:** LED turns on when the door is opening and off when closing (GPIOD PIN12)

### 2️⃣ Display
- **LCD Display:** Shows greeting messages on startup and updates the number of door openings  
- Function `open_number_write(int number)` shows the total count of door openings on the LCD  

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
- **TIM2:** Timer used for LCD updates

---

## ⚙️ STM32 Initialization

- **GPIO:**
  - PIR input configured as `GPIO_MODE_INPUT`  
  - LED and servo control pins configured as `GPIO_MODE_OUTPUT_PP`  
- **Timers:**  
  - TIM1 initialized for PWM output to servo  
  - TIM2 initialized as basic timer for LCD timing  
- **HAL Library** used for initialization and handling of peripherals  

---

## 🚀 Program Flow

1. **Startup:**  
   - LCD displays greeting message `"HELLO WORLD FROM MLK"` for 2 seconds  
   - Clears the LCD after greeting  

2. **Main Loop:**  
   - Reads PIR sensor (motion detection)  
   - If motion detected and door is closed (`movement=0`):  
     - Open the door (servo PWM set to 50)  
     - Turn on LED  
     - Display `"DOOR IS OPENING"`  
     - Increment `open_number` and update LCD  
   - If no motion and door was previously open (`movement=1`):  
     - Close the door (servo PWM set to 100)  
     - Turn off LED  
     - Display `"DOOR IS CLOSING"`  
     - Update LCD with `open_number`  

3. **Servo Stop:**  
   - Servo stops at PWM 75 after opening or closing  

---

## 🔧 Custom Functions

- `void open_number_write(int number)`  
  - Clears LCD  
  - Converts the integer `number` to string  
  - Displays `"Open Number:"` on first row and count on second row  

---

## ⚠️ Notes

- PWM duty cycle values may need adjustment for your servo (50 = open, 100 = close, 75 = stop)  
- HAL delays (`HAL_Delay`) are used for timing between actions  
- LCD library (`lcd.h`) must be included and properly configured  
- LED and servo GPIO pins can be adjusted in `MX_GPIO_Init()` if needed  

---

## 📦 Hardware Connections

| Component      | STM32 Pin       |
|----------------|----------------|
| PIR Sensor     | GPIOA PIN0      |
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
- PIR sensor  
- LED (optional for indication)
