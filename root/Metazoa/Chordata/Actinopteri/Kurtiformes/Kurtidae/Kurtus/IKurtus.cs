namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Kurtidae.Kurtus;

/// <summary>
/// Interface defining characteristics of Kurtus (genus).
/// </summary>
public interface IKurtus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
