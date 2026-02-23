namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylviidae_incertae_sedis.Panurus;

/// <summary>
/// Interface defining characteristics of Panurus (genus).
/// </summary>
public interface IPanurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
