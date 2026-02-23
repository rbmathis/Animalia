namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Celebesica;

/// <summary>
/// Interface defining characteristics of Celebesica (genus).
/// </summary>
public interface ICelebesica
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
