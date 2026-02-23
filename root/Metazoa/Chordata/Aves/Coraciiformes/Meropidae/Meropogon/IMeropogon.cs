namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Meropidae.Meropogon;

/// <summary>
/// Interface defining characteristics of Meropogon (genus).
/// </summary>
public interface IMeropogon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
