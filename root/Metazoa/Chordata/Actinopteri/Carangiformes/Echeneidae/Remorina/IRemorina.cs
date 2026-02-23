namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Remorina;

/// <summary>
/// Interface defining characteristics of Remorina (genus).
/// </summary>
public interface IRemorina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
