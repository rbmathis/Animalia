namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Thalasseus;

/// <summary>
/// Interface defining characteristics of Thalasseus (genus).
/// </summary>
public interface IThalasseus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
