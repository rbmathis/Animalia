namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Melanoptila;

/// <summary>
/// Interface defining characteristics of Melanoptila (genus).
/// </summary>
public interface IMelanoptila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
