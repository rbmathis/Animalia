namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Notharchus;

/// <summary>
/// Interface defining characteristics of Notharchus (genus).
/// </summary>
public interface INotharchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
