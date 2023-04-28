const puppeteer = require('puppeteer');
(async () => {
  const browser = await puppeteer.launch({
    headless: false,
    args: ['--headless', '--disable-gpu', '--remote-debugging-port=9222', '--no-sandbox', '--disable-setuid-sandbox']
  });
    const page = await browser.newPage();
    try{
    await page.goto('https://8081-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/');
    await page.setViewport({
      width:1200,
      height:800,
    })
      await page.click('#signupLink');
      await page.waitForNavigation();
      await page.type('#email', 'test@gmail.com');
      await page.type('#username', 'testuser');
      await page.type('#mobileNumber', '9876543210');
      await page.type('#password', 'Test@123');
      await page.type('#confirmPassword', 'Test@123');
      await page.click('#submitButton');
      await page.waitForNavigation();
      await page.waitForSelector('#loginButton',{timeout:3000});
      console.log('TESTCASE:FE_Signup:success');
    }
     catch(e){
      console.log('TESTCASE:FE_Signup:failure');
    }
    

    const page1 = await browser.newPage();
    try{
    await page1.goto('https://8081-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/');
    await page1.setViewport({
      width:1200,
      height:800,
    })
      await page1.type('#email', 'test@gmail.com');
      await page1.type('#password', 'Test@123');
      await page1.click('#loginButton');
      await page1.waitForNavigation();
      await page1.waitForSelector('#logout',{timeout:3000});
      console.log('TESTCASE:FE_Login:success');
    }
     catch(e){
      console.log('TESTCASE:FE_Login:failure');
    }


    const page2 = await browser.newPage();
    try{
    await page2.goto('https://8081-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/');
    await page2.setViewport({
      width:1200,
      height:800,
    })
    await page2.type('#email', 'test@gmail.com');
    await page2.type('#password', 'Test@123');
    await page2.click('#loginButton');
      await page2.waitForNavigation();
      await page2.waitForSelector('#logout',{timeout:3000});
      await page2.click('#userInstitute');
      await page2.waitForSelector('#userInstituteGrid1',{timeout:3000});
      await page2.click('#userInstituteGrid1');
      await page2.waitForSelector('#userCourseGrid1',{timeout:3000});
      console.log('TESTCASE:FE_UserInstituteOperation:success');
    }
     catch(e){
      console.log('TESTCASE:FE_UserInstituteOperation:failure');
    }


  const page3 = await browser.newPage();
  try{
  await page3.goto('https://8081-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/');
  await page3.setViewport({
    width:1200,
    height:800,
  })
  await page3.type('#email', 'test@gmail.com');
  await page3.type('#password', 'Test@123');
  await page3.click('#loginButton');
    await page3.waitForNavigation();
    await page3.waitForSelector('#logout',{timeout:3000});
    await page3.click('#userEnrolledCourse');
    await page3.waitForSelector('#enrolledCourse',{timeout:3000});
    await page3.click('#logout');
    await page3.waitForSelector('#loginButton',{timeout:3000});
    console.log('TESTCASE:FE_UserEnrolledCourseOperation:success');
  }
   catch(e){
    console.log('TESTCASE:FE_UserEnrolledCourseOperation:failure');
  }

  const page4 = await browser.newPage();
  try{
  await page4.goto('https://8081-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/');
  await page4.setViewport({
    width:1200,
    height:800,
  })
    await page4.type('#email', 'admin@gmail.com');
    await page4.type('#password', 'Admin@123');
    await page4.click('#loginButton');
    await page4.waitForNavigation();
    await page4.waitForSelector('#logout',{timeout:3000});
    await page4.click('#adminInstitute');
    await page4.waitForSelector('#adminInstituteGrid1',{timeout:3000});
    await page4.click('#adminCourse');
    await page4.waitForSelector('#courseGrid1',{timeout:3000});
    console.log('TESTCASE:FE_AdminInstituteCourseOperation:success');
  }
   catch(e){
    console.log('TESTCASE:FE_AdminInstituteCourseOperation:failure');
  }



  const page5 = await browser.newPage();
  try{
  await page5.goto('https://8081-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/');
  await page5.setViewport({
    width:1200,
    height:800,
  })
    await page5.type('#email', 'admin@gmail.com');
    await page5.type('#password', 'Admin@123');
    await page5.click('#loginButton');
    await page5.waitForNavigation();
    await page5.waitForSelector('#logout',{timeout:3000});
    await page5.click('#adminStudents');
    await page5.waitForSelector('#addStudent',{timeout:3000});
    await page5.click('#logout');
    await page5.waitForSelector('#loginButton',{timeout:3000});
    console.log('TESTCASE:FE_AdminStudentsOperation:success');
  }
   catch(e){
    console.log('TESTCASE:FE_AdminStudentsOperation:failure');
  }finally{
    await page.close();
    await page1.close();
    await page2.close();
    await page3.close();
    await page4.close();
    await page5.close();
    await browser.close();
  }
  
})();