document.addEventListener('DOMContentLoaded', function () {
    
    // Функция для отображения модального окна
    function toggleLoginForm() {
        const formContainer = document.querySelector(".container-login-registration");
        formContainer.classList.toggle("active");
    }

    // Открытие формы входа
    const signInBtn = document.querySelector('.signin-btn');
    if (signInBtn) {
        signInBtn.addEventListener('click', function () {
            document.querySelector('.form_signup').classList.remove('active');
            document.querySelector('.form_signin').classList.add('active');
            toggleLoginForm();
        });
    }

    // Открытие формы регистрации
    const signUpBtn = document.querySelector('.signup-btn');
    if (signUpBtn) {
        signUpBtn.addEventListener('click', function () {
            document.querySelector('.form_signin').classList.remove('active');
            document.querySelector('.form_signup').classList.add('active');
            toggleLoginForm();
        });
    }

    // Закрытие формы при клике на оверлей
    const overlay = document.querySelector('.overlay');
    if (overlay) {
        overlay.addEventListener('click', toggleLoginForm);
    }

    // Закрытие формы при клике на крестик
    const closeBtn = document.querySelector('.close-btn');
    if (closeBtn) {
        closeBtn.addEventListener('click', toggleLoginForm);
    }

    
    
    
    // Новый код для fetch запроса к GetData методу
    function fetchData() {
        const requestURL = '/Home/GetData';

        fetch(requestURL)
            .then(response => response.json())
            .then(data => {
                console.log('Успешный ответ:', data);
                document.getElementById('data').innerHTML = `Name: ${data.Name}, Age: ${data.Age}`;
            })
            .catch(err => console.error('Ошибка:', err));
    }
    // Вызов функции fetchData при загрузке страницы
    fetchData();
    
    function sendRequest(method, url, body = null){
        const headers ={
            'Content-Type': 'application/json'
        }
        return fetch(url,{
            method: method,
            body: JSON.stringify(body),
            headers: headers
        }).then(response => {
            if (!response.ok) {
                return response.json().then(errorData =>{
                    throw errorData;
                })
            }
            return response.json();
        })
    }
    function displayErrors(errors, errorContainer){
        errorContainer.innerHTML = '';//Cleaning last errors
        errors.forEach(error =>{
            const errorMessage = document.createElement('div');
            errorMessage.classList.add('error');
            errorMessage.textContent = error;
            errorContainer.appendChild(errorMessage);
        })
    }
    function cleaningAndClosingForm(form, errorContainer){
        errorContainer.innerHTML = '';
        for(const key in form){
            if (form.hasOwnProperty(key)){
                form[key].value = ''; //сброс значений полей формы
            }
        }
        closeModal(); // Закрытие окна после очистки формы
    }
    function closeModal() {
        const formContainer = document.querySelector(".container-login-registration");
        formContainer.classList.remove("active");
    }
    
    //signin
    const form_btn_signin = document.querySelector('.form_btn_signin');
    const form_btn_signup = document.querySelector('.form_btn_signup');
    
    if(form_btn_signin) {
        form_btn_signin.addEventListener('click', function (){
            const requestURL = 'Home/Login'

            const errorContainer = document.getElementById('error-messages-signin')
            
            const form = {
                email: document.getElementById("signin-email"),
                password: document.getElementById("signin-password")
            }
            
            const body = {
                email: form.email.value,
                password: form.password.value
            }
            
            sendRequest('POST', requestURL, body)
                .then(data => {
                    cleaningAndClosingForm(form, errorContainer);
                    
                    console.log('Успешный ответ:', data);
                })
                .catch(err => {
                    displayErrors(err, errorContainer);
                    
                    console.log(err);
            })
        })
    }
    
    //signup
    if(form_btn_signup) {
        form_btn_signup.addEventListener('click', function (){
            const requestURL = 'Home/Register'

            const errorContainer = document.getElementById('error-messages-signup')
            
            const form = {
                login: document.getElementById("signup-login"),
                email: document.getElementById("signup-email"),
                password: document.getElementById("signup-password"),
                passwordConfirm: document.getElementById("signup-confirm-password")
            }

            const body = {
                login: form.login.value,
                email: form.email.value,
                password: form.password.value,
                passwordConfirm: form.passwordConfirm.value
            }

            sendRequest('POST', requestURL, body)
                .then(data => {
                    cleaningAndClosingForm(form, errorContainer);
                    
                    console.log('Успешный ответ:', data);
                })
                .catch(err => {
                    displayErrors(err, errorContainer);
                    
                    console.log(err);
                })
        })
    }
});