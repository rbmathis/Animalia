namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Retropinnidae.Stokellia;

/// <summary>
/// Interface defining characteristics of Stokellia (genus).
/// </summary>
public interface IStokellia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
