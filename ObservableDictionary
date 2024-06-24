using System;
using System.Collections.Generic;

public class RecipeManager
{
    // ObservableDictionary를 사용하여 레시피와 그에 필요한 재료들을 관리합니다.
    private ObservableDictionary<string, List<string>> recipes = new ObservableDictionary<string, List<string>>();

    public RecipeManager()
    {
        // 사전 변경 이벤트에 대한 구독
        recipes.DictionaryChanged += Recipes_DictionaryChanged;
    }

    // 레시피와 필요한 재료들을 추가합니다.
    public void AddRecipe(string recipeName, List<string> ingredients)
    {
        recipes.Add(recipeName, ingredients);
    }

    // 레시피와 필요한 재료들을 제거합니다.
    public void RemoveRecipe(string recipeName)
    {
        recipes.Remove(recipeName);
    }

    // 사전 변경 이벤트 핸들러
    private void Recipes_DictionaryChanged(object sender, DictionaryEventArgs<string, List<string>> e)
    {
        switch (e.ChangeType)
        {
            case DictionaryChangeType.Added:
                Console.WriteLine($"새로운 레시피 '{e.Key}'가 추가되었습니다.");
                break;
            case DictionaryChangeType.Removed:
                Console.WriteLine($"레시피 '{e.Key}'가 삭제되었습니다.");
                break;
            case DictionaryChangeType.Modified:
                Console.WriteLine($"레시피 '{e.Key}'가 수정되었습니다.");
                break;
            default:
                break;
        }
    }
}

// ObservableDictionary를 사용하는 예제
class Program
{
    static void Main()
    {
        RecipeManager manager = new RecipeManager();

        // 레시피 추가 예시
        manager.AddRecipe("스파게티", new List<string> { "파스타 면", "토마토 소스", "치즈" });

        // 레시피 제거 예시
        manager.RemoveRecipe("스파게티");

        // 레시피 수정 예시
        manager.AddRecipe("피자", new List<string> { "밀가루", "토마토 소스", "치즈" });
        manager.recipes["피자"].Add("페퍼로니"); // 재료 추가
    }
}
