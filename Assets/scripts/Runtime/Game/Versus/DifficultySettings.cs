using UnityEngine;

namespace Pon
{
  [CreateAssetMenu(fileName = "Difficulty", menuName = "Game/Difficulty Settings", order = 0)]
  public class DifficultySettings : ScriptableObject
  {
    public string nameKey;
    public AISettings aiSettings;
  }
}