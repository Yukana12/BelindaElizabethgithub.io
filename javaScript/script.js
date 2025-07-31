const mensaje = [
    "Te adoro mucho 💗",
    "Gracias por hablar conmigo 😊",
    "Eres mi persona favorita 🌟",
    "La mujer más bella que conozco 😍",
    "Quiero estar siempre contigo 💞",
    "Gracias por preocuparte 🥰",
    "Te quiero tanto ❤️",
    "Gracias por llegar a mi vida 🌹",
    "Tu sonrisa me ilumina 😄",
    "Mis ojos son tuyos 👀",
    "Siempre pienso en ti 💭",
    "Me enamore de ti ✨",
    "Eres la razon de mi felicidad 😊",
    "Me encantan tus fotos 📸",
];

const activeBubbles = [];

function isOverlapping(newBubbleRect, newBubble) {
    for (const bubble of activeBubbles) {
        const rect = bubble.getBoundingClientRect();
        const margin = 10;
        const isTooClose = (
            newBubbleRect.left < rect.right + margin &&
            newBubbleRect.right > rect.left - margin &&
            newBubbleRect.top < rect.bottom + margin &&
            newBubbleRect.bottom > rect.top - margin
        );
        if (isTooClose) return true;
    }
    return false;
}

function createTextBubble() {
    const bubble = document.createElement("div");
    bubble.className = "texto-burbujas";
    bubble.innerText = mensaje[Math.floor(Math.random() * mensaje.length)];

    const container = document.getElementById("texto-burbujas");
    
    bubble.style.visibility = "hidden";
    bubble.style.position = "absolute";
    container.appendChild(bubble);
    
    const rect = bubble.getBoundingClientRect();
    const maxLeft = window.innerWidth - rect.width - 10;
    const maxTop = window.innerHeight - rect.height - 10;
    
    // Ajustar márgenes según el tamaño de la pantalla
    const isMobile = window.innerWidth <= 768;
    const minLeft = isMobile ? 15 : 10; // Margen izquierdo más amplio en móviles
    const maxLeftPercent = 100 - (rect.width / window.innerWidth * 100);
    
    let left, top, newBubbleRect;
    let attempts = 0;
    const maxAttempts = 10;

    do {
        left = Math.random() * (maxLeftPercent - minLeft) * 0.8 + minLeft;
        top = Math.random() * (100 - (rect.height / window.innerHeight * 100)) * 0.8 + 10;
        bubble.style.left = left + "vw";
        bubble.style.top = top + "vh";
        newBubbleRect = bubble.getBoundingClientRect();
        attempts++;
    } while (isOverlapping(newBubbleRect, bubble) && attempts < maxAttempts);

    bubble.style.visibility = "visible";

    if (newBubbleRect.right > window.innerWidth) {
        bubble.style.left = `${maxLeft}px`;
    }
    if (newBubbleRect.bottom > window.innerHeight) {
        bubble.style.top = `${maxTop}px`;
    }
    if (newBubbleRect.left < 0) {
        bubble.style.left = `${minLeft}vw`;
    }
    if (newBubbleRect.top < 0) {
        bubble.style.top = "10px";
    }

    activeBubbles.push(bubble);

    setTimeout(() => {
        bubble.remove();
        const index = activeBubbles.indexOf(bubble);
        if (index > -1) {
            activeBubbles.splice(index, 1);
        }
    }, 8000);
}

setInterval(createTextBubble, 1000);
