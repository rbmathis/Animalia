namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Chitra;

/// <summary>
/// Interface defining characteristics of Chitra (genus).
/// </summary>
public interface IChitra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
