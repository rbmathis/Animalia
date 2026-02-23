namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Kyphosus;

/// <summary>
/// Interface defining characteristics of Kyphosus (genus).
/// </summary>
public interface IKyphosus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
