using System;

Video video1 = new("Object-oriented Programming in 7 minutes | Mosh", "Programming with Mosh", 453);
Comment comment1 = new("@dizelvinable","Finally an example of OOP without a car! Thank you!");
Comment comment2 = new("@xxxxxGhostBoyxxxxx","God level explanation. Like seriously. I was a graduate in Software Engineering but when I watched this like a revelation to me. LOL. thank you good sir.");
Comment comment3 = new("@FiReOaNdDeMoS2121","OMG everything just clicks and makes so much sense, thank you for making this video <3 - perfect balance of explanation and really well timed and well chosen diverse examples");
video1.SaveComment(comment1);
video1.SaveComment(comment2);
video1.SaveComment(comment3);

Video video2 = new("Design Patterns in Plain English | Mosh Hamedani", "Programming with Mosh", 4800);
comment1 = new("@user-dr6fd1db5r","If it were a piece of music, it would win a Grammy, if it was a feature film, I would get an Oscar. So it is a programming course about the patterns, oop, solid, interfaces that every developer should see. Its the best explanation i have ever seen. Thank you, Mosh, for the great work!");
comment2 = new("@israilkarud9293","Liked + subscribed + got notifications + save to my daily notes + save to Habitica app + saved to Trello website + wrote ur name on my room wall");
comment3 = new("@FiReOaNdDeMoS2121","Mosh's teaching is the best in the world. Great Educator. Lots of love");
video2.SaveComment(comment1);
video2.SaveComment(comment2);
video2.SaveComment(comment3);

Video video3 = new("ChatGPT Tutorial for Developers - 38 Ways to 10x Your Productivity", "Programming with Mosh", 1692);
comment1 = new("@programmingwithmosh","Whether you like ChatGPT or not, remember: ChatGPI and AI are here to stay. Rather than resisting this reality, you should embrace it and learn how to use these technologies to stay current and competitive.");
comment2 = new("@DAERR_fps","While I was preparing for my final exam, I asked several questions about Online algorithms, Linear algebra, Image processing, Transformations using matrices, etc. ChatGPT's answers weren't always the best, but were a very good starting point to understanding these concepts.");
comment3 = new("@siphillis","Okay, if Mosh is recommending we learn ChatGPT, it's probably a good idea.");
video3.SaveComment(comment1);
video3.SaveComment(comment2);
video3.SaveComment(comment3);

Console.Clear();
video1.DisplayVideo(1);
video2.DisplayVideo(2);
video3.DisplayVideo(3);