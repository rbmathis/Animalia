namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Kryptolebias;

/// <summary>
/// Interface defining characteristics of Kryptolebias (genus).
/// </summary>
public interface IKryptolebias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
