namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae.Bathypterois;

/// <summary>
/// Interface defining characteristics of Bathypterois (genus).
/// </summary>
public interface IBathypterois
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
