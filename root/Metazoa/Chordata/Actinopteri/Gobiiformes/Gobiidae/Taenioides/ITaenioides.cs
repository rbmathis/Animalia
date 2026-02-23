namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Taenioides;

/// <summary>
/// Interface defining characteristics of Taenioides (genus).
/// </summary>
public interface ITaenioides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
