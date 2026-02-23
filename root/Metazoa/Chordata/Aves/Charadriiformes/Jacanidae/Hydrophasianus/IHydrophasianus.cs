namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae.Hydrophasianus;

/// <summary>
/// Interface defining characteristics of Hydrophasianus (genus).
/// </summary>
public interface IHydrophasianus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
