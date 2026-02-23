namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Meliphaga;

/// <summary>
/// Interface defining characteristics of Meliphaga (genus).
/// </summary>
public interface IMeliphaga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
