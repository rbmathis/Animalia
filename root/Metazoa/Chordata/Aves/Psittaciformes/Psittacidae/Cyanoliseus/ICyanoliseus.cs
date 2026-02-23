namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Cyanoliseus;

/// <summary>
/// Interface defining characteristics of Cyanoliseus (genus).
/// </summary>
public interface ICyanoliseus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
