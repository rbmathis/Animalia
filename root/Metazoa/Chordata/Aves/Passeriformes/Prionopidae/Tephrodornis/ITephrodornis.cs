namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae.Tephrodornis;

/// <summary>
/// Interface defining characteristics of Tephrodornis (genus).
/// </summary>
public interface ITephrodornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
