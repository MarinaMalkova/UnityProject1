using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    [SerializeField] private Sprite portrait = null;
    public Sprite Portrait => portrait;


    [SerializeField] private string _name = "";
    public string Name => _name;

    [SerializeField] public string text = "";


    [System.Serializable]
    public class Quest
    {
        public Inventory.Item item;
        public string afterCompleteText;
        public Inventory.Item reward;
    }

    [SerializeField] private List<Quest> quests;
    private int currentQuest = 0;

    void QuestUpdate(Inventory.Item item)
    {
        for (int i = currentQuest; i < quests.Count; i++)
        {
            if (quests[i].item.name == item.name && item.count >= quests[i].item.count)
            {
                quests[i].item.count = 0;
                if (i == currentQuest)
                {
                    while (currentQuest < quests.Count && quests[currentQuest].item.count == 0)
                    {
                        text = quests[currentQuest].afterCompleteText;
                        if (quests[currentQuest].reward != null)
                        {
                            var giveItems = GetComponent<GiveItemsInteraction>();
                            if (!giveItems) giveItems = gameObject.AddComponent<GiveItemsInteraction>();
                            giveItems.AddToList(quests[currentQuest].reward);
                        }
                        currentQuest += 1;
                    }
                }
            }
        }
    }
    private void Awake()
    {
        GameObject.FindWithTag("Player").GetComponent<Inventory>().Notify += QuestUpdate;
    }
}