namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Hyperprosopon;

/// <summary>
/// Interface defining characteristics of Hyperprosopon (genus).
/// </summary>
public interface IHyperprosopon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
