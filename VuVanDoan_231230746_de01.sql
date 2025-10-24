
--CREATE DATABASE VuVanDoan_231230746_de01
--GO

-- 2. Sử dụng Cơ sở dữ liệu vừa tạo
USE VuVanDoan_231230746_de01
GO

-- 3. Tạo bảng vvdComputer
CREATE TABLE vvdComputer
(
    vvdComId INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự động tăng
    vvdComName NVARCHAR(255) NOT NULL,     -- Tên máy tính
    vvdComPrice DECIMAL(18, 2),            -- Giá (cho phép số lẻ)
    vvdComImage VARCHAR(255),              -- Tên file ảnh (hoặc URL)
    vvdComStatus BIT                       -- Trạng thái (1 = true, 0 = false)
);
GO

-- 4. Thêm 3 bản ghi mẫu (gồm thông tin sinh viên dự thi)
INSERT INTO vvdComputer (vvdComName, vvdComPrice, vvdComImage, vvdComStatus)
VALUES
(N'Máy tính Sinh viên VuVanDoan', 1500, 'image_sv.jpg', 1), -- Thông tin SV
(N'Laptop Gaming XYZ', 3500, 'laptop_gaming.png', 1),       -- Máy 2
(N'Macbook Pro M3', 4999, 'macbook.jpg', 0);                 -- Máy 3
GO

-- 5. (Tùy chọn) Kiểm tra dữ liệu đã chèn
SELECT * FROM vvdComputer
GO