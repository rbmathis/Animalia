namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae.Xenomystus;

/// <summary>
/// Interface defining characteristics of Xenomystus (genus).
/// </summary>
public interface IXenomystus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
