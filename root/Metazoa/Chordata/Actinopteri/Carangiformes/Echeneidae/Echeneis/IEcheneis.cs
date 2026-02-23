namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Echeneis;

/// <summary>
/// Interface defining characteristics of Echeneis (genus).
/// </summary>
public interface IEcheneis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
