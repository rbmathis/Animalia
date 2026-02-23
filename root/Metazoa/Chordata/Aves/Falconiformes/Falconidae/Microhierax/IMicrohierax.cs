namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Microhierax;

/// <summary>
/// Interface defining characteristics of Microhierax (genus).
/// </summary>
public interface IMicrohierax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
