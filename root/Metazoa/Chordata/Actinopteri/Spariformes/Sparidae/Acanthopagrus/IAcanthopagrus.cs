namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Acanthopagrus;

/// <summary>
/// Interface defining characteristics of Acanthopagrus (genus).
/// </summary>
public interface IAcanthopagrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
