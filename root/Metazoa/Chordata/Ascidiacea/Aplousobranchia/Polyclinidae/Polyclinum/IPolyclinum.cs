namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Polyclinum;

/// <summary>
/// Interface defining characteristics of Polyclinum (genus).
/// </summary>
public interface IPolyclinum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
