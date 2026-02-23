namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Ammocrypta;

/// <summary>
/// Interface defining characteristics of Ammocrypta (genus).
/// </summary>
public interface IAmmocrypta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
