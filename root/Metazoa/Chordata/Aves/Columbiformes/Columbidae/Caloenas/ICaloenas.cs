namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Caloenas;

/// <summary>
/// Interface defining characteristics of Caloenas (genus).
/// </summary>
public interface ICaloenas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
