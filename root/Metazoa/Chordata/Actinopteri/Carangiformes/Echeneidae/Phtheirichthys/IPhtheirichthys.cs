namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Phtheirichthys;

/// <summary>
/// Interface defining characteristics of Phtheirichthys (genus).
/// </summary>
public interface IPhtheirichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
