/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.h
  * @brief          : Header for main.c file.
  *                   This file contains the common defines of the application.
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2025 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */

/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MAIN_H
#define __MAIN_H

#ifdef __cplusplus
extern "C" {
#endif

/* Includes ------------------------------------------------------------------*/
#include "stm32f4xx_hal.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */

/* USER CODE END Includes */

/* Exported types ------------------------------------------------------------*/
/* USER CODE BEGIN ET */

/* USER CODE END ET */

/* Exported constants --------------------------------------------------------*/
/* USER CODE BEGIN EC */

/* USER CODE END EC */

/* Exported macro ------------------------------------------------------------*/
/* USER CODE BEGIN EM */

/* USER CODE END EM */

void HAL_TIM_MspPostInit(TIM_HandleTypeDef *htim);

/* Exported functions prototypes ---------------------------------------------*/
void Error_Handler(void);

/* USER CODE BEGIN EFP */

/* USER CODE END EFP */

/* Private defines -----------------------------------------------------------*/
#define lcd1_Pin GPIO_PIN_1
#define lcd1_GPIO_Port GPIOA
#define lcd2_Pin GPIO_PIN_2
#define lcd2_GPIO_Port GPIOA
#define lcd3_Pin GPIO_PIN_3
#define lcd3_GPIO_Port GPIOA
#define lcd4_Pin GPIO_PIN_4
#define lcd4_GPIO_Port GPIOA
#define lcd5_Pin GPIO_PIN_5
#define lcd5_GPIO_Port GPIOA
#define lcd6_Pin GPIO_PIN_6
#define lcd6_GPIO_Port GPIOA
#define lcd7_Pin GPIO_PIN_7
#define lcd7_GPIO_Port GPIOA
#define servo_Pin GPIO_PIN_9
#define servo_GPIO_Port GPIOE
#define led_Pin GPIO_PIN_12
#define led_GPIO_Port GPIOD

/* USER CODE BEGIN Private defines */

/* USER CODE END Private defines */

#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H */
