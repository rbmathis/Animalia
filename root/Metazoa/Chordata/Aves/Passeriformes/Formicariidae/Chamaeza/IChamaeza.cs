namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Chamaeza;

/// <summary>
/// Interface defining characteristics of Chamaeza (genus).
/// </summary>
public interface IChamaeza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
