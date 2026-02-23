namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Crotophagidae.Guira;

/// <summary>
/// Interface defining characteristics of Guira (genus).
/// </summary>
public interface IGuira
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
