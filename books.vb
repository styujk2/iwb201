<!DOCTYPE html>
<html lang="ar">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>الكتب</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            direction: rtl;
            margin: 20px;
            background-color: #f9f9f9;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }
        th, td {
            padding: 10px;
            border: 1px solid #ccc;
            text-align: center;
        }
        th {
            background-color: #f2f2f2;
        }
        .details {
            display: none;
            background-color: #f9f9f9;
            border: 1px solid #ddd;
            margin-top: 10px;
            padding: 10px;
        }
        .toggle-btn {
            cursor: pointer;
            color: blue;
            text-decoration: underline;
        }
        .details-content {
            text-align: right;
        }
    </style>
</head>
<body>

    <h1>الكتب</h1>
    <table>
        <thead>
            <tr>
                <th>اختيار</th>
                <th>إظهار التفاصيل</th>
                <th>السعر</th>
                <th>العنوان</th>
                <th>رمز الكتاب</th>
                
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><input type="checkbox"></td>
                <td><span class="toggle-btn" onclick="toggleDetails('details1')">إظهار التفاصيل</span></td>
                <td>25000 ل.س</td>
                <td>ألف ليلة وليلة</td>
                <td>978-9770916738</td>
                
            </tr>
            <tr id="details1" class="details">
                <td colspan="6" class="details-content">
                    <strong>الناشر:</strong> دار المعارف<br>
                    <strong>تصنيف الكتاب:</strong> قصص شعبية<br>
                    <strong>ملخص:</strong> كتاب أسطوري يضم مجموعة من القصص الشعبية من الشرق الأوسط وجنوب آسيا وشمال إفريقيا، تم جمعها خلال العصر الذهبي للإسلام. يتم سرد القصص ضمن إطار قصة مركزية تتضمن الشخصية الرئيسية، شهرزاد، التي تحكي حكايات للملك شهريار لتأجيل إعدامه.<br>
                    <strong>أهم ثلاث قصص:</strong><br>
                    - علاء الدين والمصباح السحري<br>
                    - علي بابا والأربعون حرامي<br>
                    - رحلات السندباد السبع
                </td>
            </tr>
            <tr>
                <td><input type="checkbox"></td>
                <td><span class="toggle-btn" onclick="toggleDetails('details2')">إظهار التفاصيل</span></td>
                <td>12000 ل.س</td>
                <td>موسم الهجرة إلى الشمال</td>
                <td>978-9953891718</td>
                
            </tr>
            <tr id="details2" class="details">
                <td colspan="6" class="details-content">
                    <strong>الناشر:</strong> دار العودة<br>
                    <strong>تصنيف الكتاب:</strong> روايات عربية<br>
                    <strong>ملخص:</strong> "موسم الهجرة إلى الشمال" هي رواية شهيرة للطيب صالح، تتناول صدام الحضارات بين الشرق والغرب من خلال قصة مصطفى سعيد.<br>
                </td>
            </tr>
            <tr>
                <td><input type="checkbox"></td>
                <td><span class="toggle-btn" onclick="toggleDetails('details3')">إظهار التفاصيل</span></td>
                <td>10000 ل.س</td>
                <td>الخبز الحافي</td>
                <td>978-9953451080</td>
                
            </tr>
            <tr id="details3" class="details">
                <td colspan="6" class="details-content">
                    <strong>الناشر:</strong> دار الساقي<br>
                    <strong>تصنيف الكتاب:</strong> سيرة ذاتية<br>
                    <strong>ملخص:</strong> "الخبز الحافي" هي سيرة ذاتية كتبها محمد شكري تتحدث عن الفقر والمعاناة والطفولة الصعبة في المغرب.<br>
                </td></tr>
            <tr>
              <td><input type="checkbox"></td>
              <td><span class="toggle-btn" onclick="toggleDetails('details4')">إظهار التفاصيل</span></td>
              <td>40000 ل.س</td>
              <td>ردني اليك</td>
              <td>1_33_8321_603_978</td>
              
          </tr>
          <tr id="details4" class="details">
              <td colspan="6" class="details-content">
                  <strong>الناشر:</strong> دارالأدب<br>
                  <strong>تصنيف الكتاب:</strong>روايات عربية<br>
                  <strong>ملخص:</strong>أحدث أجزاء سلسلة مدينة الحب لا يسكنها العقلاء للكاتب السعودي أحمد آل حمدان هي مزيج بين رسائل الاعتراف و مذكرات البطل مع الفتاة التي ينتهي اسمها بالتاء المربوطة. وتدير أحداث الرواية بين جدة والرياض <br>
                  
              </td>
          </tr>
          <tr>
            <td><input type="checkbox"></td>
            <td><span class="toggle-btn" onclick="toggleDetails('details5')">إظهار التفاصيل</span></td>
            <td>50000 ل.س</td>
            <td>في قلبي أنثى عبرية</td>
            <td>1_44_6376_977_978</td>
            
        </tr>
        <tr id="details5" class="details">
            <td colspan="6" class="details-content">
                <strong>تصنيف الكتاب:</strong>روايات عربية<br>
                <strong>الناشر:</strong>دار كيان<br>
                <strong>ملخص:</strong>تدور أحداث الرواية بين تونس و لبنان من خلال تسليط النظر على كل من يهود تونس و المقاومة في جنوب لبنان ضد الاحتلال حيث تعرض لنا الإسلام بالصورة التي يجب أن يعرض بها من خلال دعوة غير المسلمين للإسلام باستخدام الحجج والبراهين و السيرة العطرة للنبي محمد صلى الله عليه وسلم <br>
                
            </td>
        </tr>
            
              </tbody>
          </table>
      
          <script>
              function toggleDetails(id) {
                  const details = document.getElementById(id);
                  if (details.style.display === "none" || details.style.display === "") {
                      details.style.display = "table-row";
                  } else {
                      details.style.display = "none";
                  }
              }
          </script>
      
      </body>
      </html>
    