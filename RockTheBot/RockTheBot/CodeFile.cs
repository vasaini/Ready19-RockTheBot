﻿//1. Plug-in Translation 
var translationMiddleware = new TranslationMiddleware(translator, userState.CreateProperty<string>("LanguagePreference"));
options.Middleware.Add(translationMiddleware);

//2. Create the language selection card
cardButtons.Add(new MultilingualCardAction(language) { CardTitle = "Swedish", Type = ActionTypes.PostBack, Value = EnglishSwedish });
cardButtons.Add(new MultilingualCardAction(language) { CardTitle = "English", Type = ActionTypes.PostBack, Value = EnglishEnglish });
cardButtons.Add(new MultilingualCardAction(language) { CardTitle = "Romanian", Type = ActionTypes.PostBack, Value = EnglishRomanian });
cardButtons.Add(new MultilingualCardAction(language) { CardTitle = "Italian", Type = ActionTypes.PostBack, Value = EnglishItalian });

//3. Keeping track of the user state
didBotWelcomeUser.DidBotWelcomeUser = true;
await _accessors.WelcomeUserState.SetAsync(turnContext, didBotWelcomeUser);
await _accessors.UserState.SaveChangesAsync(turnContext);
