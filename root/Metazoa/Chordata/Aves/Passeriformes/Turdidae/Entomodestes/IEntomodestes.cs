namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Entomodestes;

/// <summary>
/// Interface defining characteristics of Entomodestes (genus).
/// </summary>
public interface IEntomodestes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
