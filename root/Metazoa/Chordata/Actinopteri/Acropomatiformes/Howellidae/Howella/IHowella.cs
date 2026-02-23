namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Howellidae.Howella;

/// <summary>
/// Interface defining characteristics of Howella (genus).
/// </summary>
public interface IHowella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
