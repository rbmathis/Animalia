namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Allenia;

/// <summary>
/// Interface defining characteristics of Allenia (genus).
/// </summary>
public interface IAllenia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
