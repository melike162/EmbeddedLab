# STM32 & NRF24L01 Wireless Data Transmission Project

This project enables wireless data communication between STM32 boards using NRF24L01 modules. Users can configure the board as a transmitter (Tx) or receiver (Rx) using a single codebase, with mode switching done simply by changing the `#define` directive.

---

## Features

- **Easy mode switching:** By replacing `#define tx` with `#define rx` or vice versa, the same code works in the opposite mode.  
- **Compatible boards:**  
  - TX mode: STM32F407VGTx 
  - RX mode: STM32F103C6Tx  
- **ADC-based data acquisition:** Light sensor and potentiometer values can be read and transmitted.  
- **LED status indicator:** LED shows transmission/reception status.

---

## Connections

| Signal / Pin | STM32F407VGTx (Tx) | STM32F103C6Tx (Rx) | Description |
|--------------|------------------|-------------------|------------|
| VCC  | 3.3V  | 3.3V | NRF24L01 power supply |
| GND | GND | GND | Common ground |
| CSN | PA3 | PA3 | SPI chip select |
| CE | PA4 | PA4 | NRF24L01 control pin |
| SCK | PA5 | PA5 | SPI clock line |
| MISO | PA6 | PA6 | SPI data input |
| MOSI | PA7 | PA7 | SPI data output |
| IRQ | PA0 | PA0 | Optional interrupt pin |
| LED | PD13 | PC13 | Data TX/RX status LED |
| ADC Channel 1 | PA1 | - | Light sensor(etc.) |
| ADC Channel 2 | PA2 | - | Potentiometer(etc.) |

---

## ADC Parameters

- **Scan Conversion Mode:** ENABLE  
- **Continuous Conversion Mode:** ENABLE  
- **Discontinuous Conversion Mode:** DISABLE  
- **Data Alignment:** RIGHT  
- **NbrOfConversion:** 2 (Işık sensörü ve Potansiyometre)  
- **DMA Continuous Requests:** ENABLE  
- **End of Conversion (EOC) Mode:** EOC_SEQ_CONV (All Conversions)

---

## Usage

1. Power the boards and connect the NRF24L01 modules.
2. Select the desired mode in the code:
   ```c
   #define Tx // transmitter
   // or
   #define Rx // receiver
3. Compile and upload the code.
4. The TX board reads sensor values and transmits them via NRF24L01.
5. The RX board receives the data and sends it to the UART terminal or PC.
6. The LED blinks during data transmission/reception.

---

## NRF24L01 Driver Source

**NRF24L01 driver files** (`NRF24.c`, `NRF24.h`, `NRF24_reg_addreses.h` and `NRF24_conf.h`) are located inside the 
  **`Drivers/nrf24/`** directory of the project structure.  
Driver source reference: [https://www.youtube.com/watch?v=a--IXKcEwdQ](https://www.youtube.com/watch?v=a--IXKcEwdQ)

---

## Notes

- The same code works for both TX and RX modes; only the #define directive needs to be changed.
- Payload size is set to 32 bytes (PLD_SIZE 32).
- NRF24L01 channel, data rate, and CRC settings are configured in the code.
- The boards support both continuous and single conversion modes depending on ADC settings.
- Ensure proper 3.3V or 5V power supply to the NRF24L01 module for stable operation.
