namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Pentapodus;

/// <summary>
/// Interface defining characteristics of Pentapodus (genus).
/// </summary>
public interface IPentapodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
