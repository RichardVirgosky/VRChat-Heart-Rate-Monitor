## ❤️ VRChat Heart Rate Monitor - Web Server Instruction

This tool allows you to stream or display live heart rate data using fully customizable **HTML/JS/CSS templates**. These templates are rendered by the app’s built-in local web server and can be used in **OBS** or any software supporting browser sources.

⚙️ **Supported variables** (auto-replaced by the app):
> `{HR}` → Current heart rate (BPM)  
> `{AVG}` → Average heart rate

## 📥 How to Use a Template

1. Open the **Web Server** tab in your app.
2. Enable Web Server.
3. (Optional) Change the port number if needed, default is **6969**.
3. Copy one of the template examples below and paste it into the template field.
4. Save your changes. The server will now run automatically when heart rate data is available at: `http://localhost:6969`.
5. In OBS or any other software, add that URL as a Browser Source to display the overlay.  
*(full OSB instruction below template examples)*

## 📦 Ready-to-Use Templates

Here are 3 simple templates you can use immediately:

### ❤️ 1. Heart with Dynamic Color
Changes heart color based on BPM range.  
```html
<html>
	<svg xmlns="http://www.w3.org/2000/svg" width="100%" height="100%" viewBox="0 0 24 24" style="position: relative;" id="heartSvg">
		<path d="M12 4.248c-3.148-5.402-12-3.825-12 2.944 0 4.661 5.571 9.427 12 15.808 6.43-6.381 12-11.147 12-15.808 0-6.792-8.875-8.306-12-2.944z"/>
		<text x="50%" y="47%" font-size="10" text-anchor="middle" alignment-baseline="middle" fill="white" font-weight="bold" font-family="monospace">{HR}</text>
	</svg>
	<script>
		const heartRate = {HR};
		const heartPath = document.querySelector("path");
		
		if (heartRate < 60) heartPath.setAttribute("fill", "#ff0000");
		else if (heartRate < 100) heartPath.setAttribute("fill", "#e50000");
		else if (heartRate < 140) heartPath.setAttribute("fill", "#b70000");
		else heartPath.setAttribute("fill", "#800000");  
		
		setInterval(() => location.reload(), 1000);
	</script>
</html>
```

### 💗 2. Pulsing Heart Animation
Adds a pulsing effect to the heart while keeping the BPM logic.  
```html
<html>
	<style>
	path, text {
		transform-origin: center;
		animation: pulse 1s ease-in-out infinite;
	}

	@keyframes pulse {
		0%, 100% { transform: scale(1); }
		50% { transform: scale(0.9); }
	}
	</style>
	<svg xmlns="http://www.w3.org/2000/svg" width="100%" height="100%" viewBox="0 0 24 24" style="position: relative;" id="heartSvg">
		<path d="M12 4.248c-3.148-5.402-12-3.825-12 2.944 0 4.661 5.571 9.427 12 15.808 6.43-6.381 12-11.147 12-15.808 0-6.792-8.875-8.306-12-2.944z"/>
		<text x="50%" y="47%" font-size="10" text-anchor="middle" alignment-baseline="middle" fill="white" font-weight="bold" font-family="monospace">{HR}</text>
	</svg>
	<script>
		const heartRate = {HR};
		const heartPath = document.querySelector("path");
		
		if (heartRate < 60) heartPath.setAttribute("fill", "#ff0000");
		else if (heartRate < 100) heartPath.setAttribute("fill", "#e50000");
		else if (heartRate < 140) heartPath.setAttribute("fill", "#b70000");
		else heartPath.setAttribute("fill", "#800000");  
		
		setInterval(() => location.reload(), 1000);
	</script>
</html>
```

### 🔵 3. Circular Gauge Arc
Displays the BPM as a colored progress ring.  
```html
<html>
	<svg viewBox="0 0 36 36" width="100%" height="100%">
		<pathstroke-dasharray="100, 100"stroke="#eee"stroke-width="4"fill="none"d="M18 2.0845a 15.9155 15.9155 0 0 1 0 31.831a 15.9155 15.9155 0 0 1 0 -31.831"/>
		<path stroke-dasharray="0, 100"stroke="green"stroke-width="4"fill="none"d="M18 2.0845a 15.9155 15.9155 0 0 1 0 31.831a 15.9155 15.9155 0 0 1 0 -31.831"/>
		<text x="50%" y="50%" font-size="10" text-anchor="middle" alignment-baseline="middle" fill="black" font-weight="bold" font-family="monospace">{HR}</text>
	</svg>

	<script>
		const heartRate = {HR};
		const hrArc = document.querySelector("path");

		const percent = Math.min(100, Math.round((heartRate / 200) * 100));
		hrArc.setAttribute("stroke-dasharray", `${percent}, 100`);

		if (heartRate < 50) hrArc.setAttribute("stroke", "#ffff00");
		else if (heartRate < 100) hrArc.setAttribute("stroke", "#008000");
		else if (heartRate < 120) hrArc.setAttribute("stroke", "#ffa500");
		else if (heartRate < 140) hrArc.setAttribute("stroke", "#ff0000");
		else hrArc.setAttribute("stroke", "#800000");
		
		setInterval(() => location.reload(), 1000);
	</script>
</html>
```

## 🎨 Want to Create Your Own?

You can build your own template in just a few lines of HTML, JavaScript and CSS.

### ✨ Quick Guide:
- Include `{HR}` in your code where you want **live BPM** to appear
- Optionally use `{AVH}` for average BPM
- You can style it with CSS, animate it with JS and do whatever You want with it.  
*(Don't worry! it's easier than you think!)*

### 💡 Example:
```html
<span style="font-size:28px;color:lime;font-family:monospace;">
  HR: {HR}
</span>
```

## 🖼 How to Add to OBS

> After setting the template in your app and starting the local web server:

### 🧪 Steps:
1. Open **OBS Studio**
2. Click ➕ in *Sources* → select **Browser**
3. Set the URL to: `http://localhost:6969`
4. Set dimensions (e.g. Width: `200`, Height: `200`)
5. Click **OK** and it's done! Relocate it in your scene and you're ready to go!

## 🤝 Contribute Your Templates!

Have a cool idea or made your own custom template?
Make sure to let us know on our discord! We’re happy to feature your work!

## 💬 Need Help?

- 📌 Found a bug or have a request? Join our [Discord](https://virgosky.com/dc) for template help or ideas

🎉 **Happy streaming!**  
Stay creative and monitor that heart in style!