namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae.Notacanthus;

/// <summary>
/// Interface defining characteristics of Notacanthus (genus).
/// </summary>
public interface INotacanthus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
