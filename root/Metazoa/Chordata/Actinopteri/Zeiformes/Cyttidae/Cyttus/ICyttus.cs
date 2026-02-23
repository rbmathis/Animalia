namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Cyttidae.Cyttus;

/// <summary>
/// Interface defining characteristics of Cyttus (genus).
/// </summary>
public interface ICyttus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
