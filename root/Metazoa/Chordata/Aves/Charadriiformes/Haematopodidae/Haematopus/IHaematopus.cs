namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Haematopodidae.Haematopus;

/// <summary>
/// Interface defining characteristics of Haematopus (genus).
/// </summary>
public interface IHaematopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
