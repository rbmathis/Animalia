namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Geophaps;

/// <summary>
/// Interface defining characteristics of Geophaps (genus).
/// </summary>
public interface IGeophaps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
