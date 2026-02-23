namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Melanosuchus;

/// <summary>
/// Interface defining characteristics of Melanosuchus (genus).
/// </summary>
public interface IMelanosuchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
