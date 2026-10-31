# Smart Home IoT

Ứng dụng Windows Forms (C# / .NET Framework) giám sát và điều khiển nhà thông minh qua **Firebase Realtime Database**: đọc nhiệt độ, độ ẩm và bật/tắt thiết bị (đèn, điều hoà...).

## Cấu trúc

| Thư mục | Mô tả |
|---|---|
| `SmartHomeIoT/` | Bản chính – mở bằng `SmartHomeIoT.sln` ở thư mục gốc |
| `SmartHome_final/` | Bản hoàn thiện, kết nối Firebase (Newtonsoft.Json) |
| `Smart_Home_IOT_Final_Version/` | Một phiên bản final khác |
| `firebase_connection/` | Demo đọc/ghi Firebase qua REST API |
| `WindowsFormsApplication_Iot_HMI/` | Giao diện HMI có màn hình đăng nhập |
| `SmartHome/`, `Buổi 2/`, `WindowsFormsApplication1/`, `WindowsFormsApplication2/` | Bài thực hành theo buổi |

## Yêu cầu

- Windows + Visual Studio 2015 trở lên (workload **.NET desktop development**)
- .NET Framework 4.0 / 4.5.2 Developer Pack

## Chạy dự án

1. Clone repo:
   ```bash
   git clone https://github.com/KenPTNK/smart-home-iot.git
   ```
2. Mở file `.sln` của project muốn chạy bằng Visual Studio.
3. Chuột phải Solution → **Restore NuGet Packages** (thư mục `packages/` không được commit).
4. Nhấn **F5**.

## Firebase

URL Realtime Database đang ghi trực tiếp trong code (`firebase_connection/firebase_connection/Form1.cs`). Để dùng database của bạn, thay URL đó và cấu hình **Rules** trên Firebase Console để không cho ghi công khai.
