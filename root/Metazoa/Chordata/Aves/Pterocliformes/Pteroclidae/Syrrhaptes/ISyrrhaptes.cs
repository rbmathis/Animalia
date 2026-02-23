namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pterocliformes.Pteroclidae.Syrrhaptes;

/// <summary>
/// Interface defining characteristics of Syrrhaptes (genus).
/// </summary>
public interface ISyrrhaptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
