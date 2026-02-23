namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae.Bathymicrops;

/// <summary>
/// Interface defining characteristics of Bathymicrops (genus).
/// </summary>
public interface IBathymicrops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
