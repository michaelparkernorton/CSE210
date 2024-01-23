public class PromptGenerator
{
    public string[] _prompts;

		public void LoadPrompts() {
				string fileName = "prompts.txt";
				this._prompts = System.IO.File.ReadAllLines(fileName);
		}

    public string RandomPrompt()
    {
			Random randomizer = new Random();
			int random = randomizer.Next(this._prompts.Count());
			return this._prompts[random];
    }
}