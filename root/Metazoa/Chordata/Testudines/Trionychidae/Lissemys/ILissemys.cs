namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Lissemys;

/// <summary>
/// Interface defining characteristics of Lissemys (genus).
/// </summary>
public interface ILissemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
