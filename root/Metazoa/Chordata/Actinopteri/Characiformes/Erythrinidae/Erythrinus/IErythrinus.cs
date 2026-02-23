namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Erythrinus;

/// <summary>
/// Interface defining characteristics of Erythrinus (genus).
/// </summary>
public interface IErythrinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
