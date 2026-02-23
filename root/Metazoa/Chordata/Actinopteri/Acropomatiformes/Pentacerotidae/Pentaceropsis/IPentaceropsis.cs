namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Pentaceropsis;

/// <summary>
/// Interface defining characteristics of Pentaceropsis (genus).
/// </summary>
public interface IPentaceropsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
