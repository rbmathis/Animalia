namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Nannoperca;

/// <summary>
/// Interface defining characteristics of Nannoperca (genus).
/// </summary>
public interface INannoperca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
