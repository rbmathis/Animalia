namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Conopophagidae.Conopophaga;

/// <summary>
/// Interface defining characteristics of Conopophaga (genus).
/// </summary>
public interface IConopophaga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
