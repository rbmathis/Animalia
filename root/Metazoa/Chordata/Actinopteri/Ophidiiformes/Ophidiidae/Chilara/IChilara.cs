namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Chilara;

/// <summary>
/// Interface defining characteristics of Chilara (genus).
/// </summary>
public interface IChilara
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
