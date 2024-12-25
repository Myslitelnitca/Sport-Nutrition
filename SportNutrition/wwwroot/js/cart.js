// Функция для уменьшения количества товара
function decreaseQuantity(button) {
    const quantitySpan = button.nextElementSibling;
    let quantity = parseInt(quantitySpan.textContent);
    if (quantity > 1) {
        quantity--;
        quantitySpan.textContent = quantity;
        updateTotalPrice();
    }
}

// Функция для увеличения количества товара
function increaseQuantity(button) {
    const quantitySpan = button.previousElementSibling;
    let quantity = parseInt(quantitySpan.textContent);
    quantity++;
    quantitySpan.textContent = quantity;
    updateTotalPrice();
}

// Функция для удаления товара из корзины
function removeItem(button) {
    const cartItem = button.closest('.cart-item');
    cartItem.remove();
    updateTotalPrice();
}

// Функция для пересчёта общей стоимости
function updateTotalPrice() {
    const cartItems = document.querySelectorAll('.cart-item');
    let total = 0;

    cartItems.forEach((item) => {
        const priceText = item.querySelector('.cart-item-price').textContent;
        const price = parseInt(priceText.replace('₽', '').trim());
        const quantity = parseInt(item.querySelector('.quantity-value').textContent);
        total += price * quantity;
    });

    const totalPriceElement = document.getElementById('total-price');
    totalPriceElement.textContent = `${total} ₽`;
}

// Функция оформления заказа
function checkout() {
    alert('Ваш заказ оформлен!');
    // Здесь можно добавить логику для отправки данных на сервер
}


//добавить в корзинууу

// Массив для хранения товаров в корзине
let cart = [];

// Функция для добавления товара в корзину
function addToCart(button) {
    const productCard = button.closest('.product-card');
    const title = productCard.querySelector('.product-title').textContent;
    const priceText = productCard.querySelector('.product-price').textContent;
    const price = parseFloat(priceText.replace('₽', '').trim());

    // Проверяем, есть ли товар в корзине
    const existingProduct = cart.find(product => product.title === title);

    if (existingProduct) {
        // Если товар уже есть в корзине, увеличиваем количество
        existingProduct.quantity++;
    } else {
        // Если товара нет, добавляем новый объект
        cart.push({
            title: title,
            price: price,
            quantity: 1
        });
    }

    // Обновляем отображение корзины
    updateCart();
}

// Функция для отображения корзины
function updateCart() {
    const cartItemsContainer = document.querySelector('.cart-items');
    cartItemsContainer.innerHTML = ''; // Очищаем содержимое корзины

    cart.forEach(product => {
        const cartItem = document.createElement('div');
        cartItem.classList.add('cart-item', 'row', 'mb-3');

        cartItem.innerHTML = `
            <div class="col-md-4">
                <img src="/img/catalog/whey.jpg" alt="${product.title}" class="img-fluid">
            </div>
            <div class="col-md-4">
                <p class="cart-item-title">${product.title}</p>
                <p class="cart-item-price">${product.price} ₽</p>
            </div>
            <div class="col-md-2">
                <div class="quantity">
                    <button class="btn btn-secondary btn-sm" onclick="decreaseQuantity(this)">-</button>
                    <span class="quantity-value">${product.quantity}</span>
                    <button class="btn btn-secondary btn-sm" onclick="increaseQuantity(this)">+</button>
                </div>
            </div>
            <div class="col-md-2">
                <button class="btn btn-danger btn-sm" onclick="removeItem(this)">Удалить</button>
            </div>
        `;

        cartItemsContainer.appendChild(cartItem);
    });

    // Пересчитываем общую стоимость
    updateTotalPrice();
}

