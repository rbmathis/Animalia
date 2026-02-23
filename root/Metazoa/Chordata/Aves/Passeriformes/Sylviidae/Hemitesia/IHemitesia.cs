namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Hemitesia;

/// <summary>
/// Interface defining characteristics of Hemitesia (genus).
/// </summary>
public interface IHemitesia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
