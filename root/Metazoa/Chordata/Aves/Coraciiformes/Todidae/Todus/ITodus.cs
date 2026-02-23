namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Todidae.Todus;

/// <summary>
/// Interface defining characteristics of Todus (genus).
/// </summary>
public interface ITodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
