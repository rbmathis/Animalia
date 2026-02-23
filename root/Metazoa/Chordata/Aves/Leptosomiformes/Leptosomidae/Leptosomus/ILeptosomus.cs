namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Leptosomiformes.Leptosomidae.Leptosomus;

/// <summary>
/// Interface defining characteristics of Leptosomus (genus).
/// </summary>
public interface ILeptosomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
