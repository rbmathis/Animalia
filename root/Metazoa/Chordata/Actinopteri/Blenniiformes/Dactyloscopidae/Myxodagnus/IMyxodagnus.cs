namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.Myxodagnus;

/// <summary>
/// Interface defining characteristics of Myxodagnus (genus).
/// </summary>
public interface IMyxodagnus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
