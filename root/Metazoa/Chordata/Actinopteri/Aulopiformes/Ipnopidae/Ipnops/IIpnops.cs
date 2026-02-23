namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae.Ipnops;

/// <summary>
/// Interface defining characteristics of Ipnops (genus).
/// </summary>
public interface IIpnops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
