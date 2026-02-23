namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Drymocichla;

/// <summary>
/// Interface defining characteristics of Drymocichla (genus).
/// </summary>
public interface IDrymocichla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
