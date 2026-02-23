namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae.Evermannella;

/// <summary>
/// Interface defining characteristics of Evermannella (genus).
/// </summary>
public interface IEvermannella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
