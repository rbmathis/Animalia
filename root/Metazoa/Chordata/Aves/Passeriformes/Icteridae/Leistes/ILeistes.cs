namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Leistes;

/// <summary>
/// Interface defining characteristics of Leistes (genus).
/// </summary>
public interface ILeistes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
