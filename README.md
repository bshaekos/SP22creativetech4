# Creative Tech 4 - Spring 2022

## Project 1: Rube Goldberg Machine 

### Tools:

HTML, CSS and IFTT

### Timeline: 

3 weeks

### Teammate: 

Yining Gao

### Advisors:

Maxim Safioulline and Ben Hooker

### Project Brief: 

The Web was built around the concept of requests and responses - a constant back and forth between a server on the Internet and a browser on your computer. As it grew and expanded the need arose to get exchange going not just between a person and a machine but among many machines.

A user initiates a single action - a click of a button, a text entry, a page scroll - and the browser triggers a chain of events, most of them hidden behind the veil of the Cloud, to pass around some data from one server to another, like a ball in a pinball machine. The data can be used to request other data, to trigger different responses from servers, to capture more data. It can be formatted, rearranged, displayed in different contexts, - juxtaposed with other data.

In the spirit of Rube Goldberg's fascination with the mechanism over the end result - how can we build similar systems in the digital realm? What kind of data could be passed around? With services could be chained together to produce some unexpected outcomes? What would the triggers look like - and the end results? None of those need to be practical, efficient or even reasonable - the focus is on the celebration of the chains of events and the mechanisms that enable them.

### Process Sketches:

First, from a list of APIs provided by our professors, Yining and I outlined the APIs that we found most interesting. Second, we discussed and roughly sketeched how we might connect those APIs togethered based off of the available data. Third, we began formatting the code so that we could retrieve the exact piece of information from each API. Lastly, we modified our initial ideas according to testing so that the entire string of APIs could function properly, each step triggering the next.


![Yining   Blake - RUBE GOLDBERG MACHINE - Process Sketches](https://user-images.githubusercontent.com/76088958/164383824-9c80c666-1a1c-4811-b1f0-4d02b2d840f4.jpg)


### System Architecture:

In the end the mix of APIs changed in order to successfully complete a Rube Goldberg machine. 

![Yining   Blake - RUBE GOLDBERG MACHINE - System Architecture](https://user-images.githubusercontent.com/76088958/164376567-c9c4c608-d906-451e-901c-77a9c4ec1439.jpg)


### Project Documentation:


https://user-images.githubusercontent.com/76088958/160047614-8f8afd4e-f3a1-475e-9e94-02c47cc75a2b.mp4


[Rube Goldberg Machine_4.pdf](https://github.com/bshaekos/SP22creativetech4/files/8347009/Rube.Goldberg.Machine_4.pdf)


https://user-images.githubusercontent.com/76088958/160048030-297c0509-1142-430f-adb6-fcd4e668d8b4.mp4


[Rube Goldberg Machine_3.pdf](https://github.com/bshaekos/SP22creativetech4/files/8347008/Rube.Goldberg.Machine_3.pdf)


### Reflection:

Overall, I found the project a lot of fun and a great opportunity for me to further my front-end coding skills. I had not worked with APIs before so I learned more about how the internet functions. In addition, I become more knowledgeable about the meaning of HTML status codes as Yining and I encountered numerous as we sent GET requests to the various services. I was most frustrated by the limitations of HTML in modifying the data once we received it back from the respective service. If I had more time, I would have added some JavaScript to manipulate the data so that we could have more flexibility throughout the project. Also, the interpretation of some of the API documentation was quite ambiguous, which led to moments of uncertainty as to how to get to the data. As a result, Yining and I tested a lot to get to the right data in the right format.  


## Project 2 - Multiplayer Manufacturing Online Sitting Arena (MiMOSA)

### Tools:

Axis Neuron, Blender, Gravity Sketch, Metashape Pro, Mixamo, Tilt Brush and Unity 

### Timeline: 

3 weeks

### Advisors:

Jenny Rodenhouse, Maxim Safioulline and Ben Hooker

### Project Brief: 

After World War I, many artists, writers, and creative intellectuals started to question every aspect of their culture that had allowed the horrors of war to occur. Artists started to think about how technology, consumerism, art, and politics were all interrelated. Romanian-French poet Tristan Tzara noted, "The beginnings of Dada were not the beginnings of art, but of disgust." Artists and writers such as Tzara, Hugo Ball, Man Ray, Hannah Höch and Max Ernst decided that the only way to respond to these realizations was through irreverent and (potentially) nonsensical works. Dada artists used techniques such as collage, assemblage, and photomontage to form their works, creating new linguistic and visual languages that attempted to exist outside the rigid structures of contemporary society. The term Dada itself, though contested in origin, is said to come from its meaning of both 'Yes, yes' in Romanian and 'rocking horse' in French, demonstrating its transnational origins. By incorporating found materials into their work, creatives began to break down the distinctions between art and real life by demonstrating that art is always produced from real life. 

Today, we are feeling similar extremes of horror, disgust, and utter confusion. How might our contemporary observations of technology, consumerism, art, and politics manifest into a formal reaction and creative proposition

Explore making mixed-reality chairs by using the technique and concept of assembling, a three-dimensional alternative to collage, a technique of composing work by combining various found models (real and physical), and online materials not normally associated with one another. Through this process, we will explore new forms of manufacturing and human factors in design

### Project Documentation:

I used the Agisoft software to stitch together a 100+ photos that I captured of a chair found in the MDP studio. Then, I imported the .obj file into Blender and worked the model (e.g., removed extraneous information/elements, smoothed the base of the model to appear more like metal). 

Here are some examples of the photos that I captured of the physical chair:

![IMG_0151](https://user-images.githubusercontent.com/76088958/164580768-943a06f0-b835-4c67-a671-d6b9eacd1a88.JPG)

![IMG_0161](https://user-images.githubusercontent.com/76088958/164580795-16afeb6a-bb87-4c69-8dfc-660b254fae90.JPG)

![IMG_0166](https://user-images.githubusercontent.com/76088958/164580844-9e02262e-3935-423b-8587-29f0e35fe725.JPG)

![IMG_0173](https://user-images.githubusercontent.com/76088958/164580945-1bd3683a-5fd4-4a77-88ab-7dfeb40a2f6f.JPG)

![IMG_0184](https://user-images.githubusercontent.com/76088958/164580965-ea44e38d-8cd3-48ee-9abb-68cb6a45d803.JPG)

![IMG_0250](https://user-images.githubusercontent.com/76088958/164581046-3731c61f-0100-44a8-9b1e-8396c03e49cd.JPG)

![IMG_0259](https://user-images.githubusercontent.com/76088958/164581072-7eac4cc7-cce1-42ab-8061-65dfee98f37a.JPG)

Here is the point cloud generated in Metashape, showing all of the images and angles that generated the initial 3D model:

![Metashape-Point Cloud](https://user-images.githubusercontent.com/76088958/164619971-4e00424d-4425-42ee-ab9a-0affb1b0f9a9.png)

Here is the final output from Blender:

![Photogram-Chair](https://user-images.githubusercontent.com/76088958/164579286-37ff1923-75c5-4846-a997-0497a3f12811.png)

In addition, I motion captured my body and rigged the motion capture to a Maximo character. I placed both the chair and the rigged character into Unity scene to capture this GIF (please click to see the animated GIF):

![Walking-Sitting_Animation](https://user-images.githubusercontent.com/76088958/164609462-0df42665-8670-49f1-ac4d-58c8e430150a.gif)

In addition to using photogrammetry, I used Blender to create mash-ups of free 3D models available online. The theme that I went with was techno-apocalyse and the name of each chair are: *Lady Clock's Game*, *Mushroom at the Edge of the World* and *Til Death Due Us Part*. 

Here are the three chairs and related scenes captured from within Blender: 

![Lady_Clocks_Game-Chair](https://user-images.githubusercontent.com/76088958/164609935-23fa58f4-cdd5-4430-90c6-a47a5bdd742f.png)

![Mushroom_at_the_edge_of_the_World-Chair](https://user-images.githubusercontent.com/76088958/164609955-a8e54ee3-2260-4389-ba01-c0d0296962bc.png)

![From_Death_Due_Us_Part-Chair](https://user-images.githubusercontent.com/76088958/164609972-e0d2486a-268e-4dd2-bf29-5bc2ef65da8d.png)

Finally, I used Tilt Brush to create a chair in VR and imported it into Blender in order to capture this scene:

![VR-Chair_Scene](https://user-images.githubusercontent.com/76088958/164618010-8f66e5e7-52b2-48aa-8c78-aa2f5b8293b1.png)

### Reflection:

I was super excited to start working in Blender as I was quite disappointed with my Studio 2 project because I did not challenge myself to design in 3D. I really enjoyed the workflow of Blender to Unity with the addition of a motion capture animation. I decided on this route instead of the workflow of tying the digital model to a physical chair that the final lesson plan outlined. The reason for this change was due to the technological challenges in connecting the VR headset for live editing in Unity. The headset used inside-out tracking so the model constantly moved as Yining and I worked to accurately place the virtual model with the physical chair. I really like working in VR because it feels more nature to me then the abstraction of a mouse and buttons. Unfortunately I had a diffucult time figuring out how to add the textures from Tilt Brush into Blender once the model was loaded. After this experience and based off of my research in finding. a solution, I believe that VR allows me to create a basic form that I can refine in Blender for a final output. During the project I realized that I have an affinity for the tool, so I definitely plan to continue growing my skills in 3D modeling and animation. 


## Project 4 - Personal Project

### Tools:

Unity (VFX Graph) and Axis Neuron

### Timeline: 

2 weeks

### Advisors:

Maxim Safioulline, Ben Hooker and Jenny Rodenhouse

### Project Brief: 


### Process:

I was inspired by Theo Triantafyllidis "Anti Gone" (2020) mixed reality project, and I found Keijiro Takahashi's skinned mesh renderer VFX project mesmerizing. 
![CT4 - Project 4 - BSK](https://user-images.githubusercontent.com/76088958/164873736-1e5ac343-20c9-42ce-908e-6639ba638f47.jpg)

Here is an image of me wearing the motion capture:
![IMG_3312](https://user-images.githubusercontent.com/76088958/164873834-c88c4769-aabd-4703-b74d-4e06d9c530aa.jpg)

### Project Documentation:

Here is the scene that I created around skinned mesh renderer animation:
![Unity_Scene](https://user-images.githubusercontent.com/76088958/164618840-b0655ed2-01e7-45de-9410-4da664383634.png)

Here is the edited animation that I captured from the motion capture suit and tried to sync with the music:
![Unity_Animation](https://user-images.githubusercontent.com/76088958/164618827-67753331-1d7c-41d7-8272-e7df17a22ea2.png)

Here is the VFX graph that I created for both the skinned mesh renderer and the particle system floated around the character:
![VFX_Particle_1](https://user-images.githubusercontent.com/76088958/164618854-9d192181-96c2-43be-8587-ac015b7c9e00.png)

![VFX_Particle_2](https://user-images.githubusercontent.com/76088958/164618875-b44e9863-1134-4e22-9ff2-62d5e83ac635.png)

