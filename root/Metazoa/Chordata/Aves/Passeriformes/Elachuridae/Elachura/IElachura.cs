namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Elachuridae.Elachura;

/// <summary>
/// Interface defining characteristics of Elachura (genus).
/// </summary>
public interface IElachura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
