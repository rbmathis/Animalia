namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Plectorhyncha;

/// <summary>
/// Interface defining characteristics of Plectorhyncha (genus).
/// </summary>
public interface IPlectorhyncha
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
