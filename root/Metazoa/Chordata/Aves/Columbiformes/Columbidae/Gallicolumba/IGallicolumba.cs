namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Gallicolumba;

/// <summary>
/// Interface defining characteristics of Gallicolumba (genus).
/// </summary>
public interface IGallicolumba
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
