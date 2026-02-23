namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Draconettidae.Centrodraco;

/// <summary>
/// Interface defining characteristics of Centrodraco (genus).
/// </summary>
public interface ICentrodraco
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
