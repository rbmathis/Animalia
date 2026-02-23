namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Indotestudo;

/// <summary>
/// Interface defining characteristics of Indotestudo (genus).
/// </summary>
public interface IIndotestudo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
