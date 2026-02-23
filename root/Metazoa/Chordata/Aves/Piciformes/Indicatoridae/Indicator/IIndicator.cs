namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Indicator;

/// <summary>
/// Interface defining characteristics of Indicator (genus).
/// </summary>
public interface IIndicator
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
