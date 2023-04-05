const video = document.getElementById("video");
const canvas = document.getElementById("canvasa");
const captureButton = document.getElementById("capture");
const capturedImage = document.getElementById("capturedImage");

navigator.mediaDevices
  .getUserMedia({ video: true, audio: false })
  .then((stream) => {
    video.srcObject = stream;
  })
  .catch((error) => {
    console.error("Error accessing the webcam:", error);
  });

captureButton.addEventListener("click", () => {
  const context = canvas.getContext("2d");
  canvas.width = video.clientWidth;
  canvas.height = video.clientHeight;

  context.drawImage(video, 0, 0, canvas.width, canvas.height);
  const imageUrl = canvas.toDataURL("image/png");
  capturedImage.src = imageUrl;
});
