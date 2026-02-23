namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Travancoria;

/// <summary>
/// Interface defining characteristics of Travancoria (genus).
/// </summary>
public interface ITravancoria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
