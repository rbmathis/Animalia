namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Netuma;

/// <summary>
/// Interface defining characteristics of Netuma (genus).
/// </summary>
public interface INetuma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
