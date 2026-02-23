namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Cabalus;

/// <summary>
/// Interface defining characteristics of Cabalus (genus).
/// </summary>
public interface ICabalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
