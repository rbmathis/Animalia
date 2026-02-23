namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae.Centracanthus;

/// <summary>
/// Interface defining characteristics of Centracanthus (genus).
/// </summary>
public interface ICentracanthus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
