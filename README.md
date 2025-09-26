# STM32 Door Control with PIR and LCD Display

This project demonstrates **automatic door control** using the **STM32F407VGT6** microcontroller.  
It integrates a **PIR motion sensor**, **servo motor**, **LED indicator**, and a **16x2 LCD** to visualize door status and count the number of openings.

---

## 📁 Project Contents

### 1️⃣ STM32 CubeIDE Code (`cubeide_door`)
- Reads **motion from PIR sensor** connected to **PA0**.
- Controls **servo motor** via **PE9** using **TIM1_CH1** to open/close the door.
- Turns on an **LED on PD12** while the door is opening and keeps it on when the door is open.
- Uses a **16x2 LCD** with the following connections:
  - **VSS → GND**
  - **VDD → 5V**
  - **V0 → Potentiometer middle pin** (for contrast)
  - **RS → PA1**
  - **RW → PA2**
  - **E → PA3**
  - **D4 → PA4**
  - **D5 → PA5**
  - **D6 → PA6**
  - **D7 → PA7**
- Displays messages such as `"HELLO WORLD"`, `"DOOR IS OPENING/CLOSING"`, and the **number of times the door has opened**.

---

## ⚙️ Requirements

- **STM32 CubeIDE**
- **STM32F407G DISC1** (or equivalent)
- **16x2 LCD module**
- **Servo motor**
- **PIR motion sensor**
- **LED with resistor** (e.g., 220Ω)
- **Breadboard and jumper wires**

---

## 🚀 Usage

1. Connect all components according to the pinout described above.
2. Compile and upload the project in CubeIDE.
3. When motion is detected by the PIR sensor (**PA0**):
   - Servo motor (**PE9**) moves to open the door.
   - LED on **PD12** turns on.
   - LCD displays `"DOOR IS OPENING"`.
4. When motion stops:
   - Servo moves the door to close.
   - LED on **PD12** turns off.
   - LCD displays `"DOOR IS CLOSING"`.
5. The LCD also shows the **total number of times the door has opened**.
