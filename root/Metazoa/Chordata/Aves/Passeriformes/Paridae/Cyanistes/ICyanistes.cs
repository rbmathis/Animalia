namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Cyanistes;

/// <summary>
/// Interface defining characteristics of Cyanistes (genus).
/// </summary>
public interface ICyanistes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
