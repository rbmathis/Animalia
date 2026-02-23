namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Crotophagidae.Crotophaga;

/// <summary>
/// Interface defining characteristics of Crotophaga (genus).
/// </summary>
public interface ICrotophaga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
