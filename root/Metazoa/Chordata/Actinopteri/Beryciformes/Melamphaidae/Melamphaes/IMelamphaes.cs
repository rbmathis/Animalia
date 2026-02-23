namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Melamphaes;

/// <summary>
/// Interface defining characteristics of Melamphaes (genus).
/// </summary>
public interface IMelamphaes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
