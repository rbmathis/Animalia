namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae.Metopidius;

/// <summary>
/// Interface defining characteristics of Metopidius (genus).
/// </summary>
public interface IMetopidius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
