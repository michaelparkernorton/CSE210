using System.Diagnostics.Contracts;
using System.Text.Json;

public class Library {
	private List<Scripture> _scriptures = new List<Scripture>();
	private string[] _texts = {
		"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", 
		"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."};

		private string[] _references = {
		"Proverbs 3:5-6", 
		"1 Nephi 3:7"};

	public Library() {
		for (int i = 0; i < 2; i++)
		{
			Scripture scripture = new Scripture(_references[i], this._texts[i]);
			_scriptures.Add(scripture);
		}
	}


	public Scripture GetScripture() {
		return this._scriptures[1];
	}

}