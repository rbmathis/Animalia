namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Creagrus;

/// <summary>
/// Interface defining characteristics of Creagrus (genus).
/// </summary>
public interface ICreagrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
