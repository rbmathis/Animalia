namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Oreopsar;

/// <summary>
/// Interface defining characteristics of Oreopsar (genus).
/// </summary>
public interface IOreopsar
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
