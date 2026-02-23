namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Hydrocoloeus;

/// <summary>
/// Interface defining characteristics of Hydrocoloeus (genus).
/// </summary>
public interface IHydrocoloeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
