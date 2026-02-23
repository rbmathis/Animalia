namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Chrysocorythus;

/// <summary>
/// Interface defining characteristics of Chrysocorythus (genus).
/// </summary>
public interface IChrysocorythus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
