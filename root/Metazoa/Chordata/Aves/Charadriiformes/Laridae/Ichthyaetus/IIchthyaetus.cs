namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Ichthyaetus;

/// <summary>
/// Interface defining characteristics of Ichthyaetus (genus).
/// </summary>
public interface IIchthyaetus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
