namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Geokichla;

/// <summary>
/// Interface defining characteristics of Geokichla (genus).
/// </summary>
public interface IGeokichla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
