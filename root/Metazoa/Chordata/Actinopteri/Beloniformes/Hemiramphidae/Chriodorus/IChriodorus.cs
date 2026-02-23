namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Chriodorus;

/// <summary>
/// Interface defining characteristics of Chriodorus (genus).
/// </summary>
public interface IChriodorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
