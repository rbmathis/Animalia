namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Cardellina;

/// <summary>
/// Interface defining characteristics of Cardellina (genus).
/// </summary>
public interface ICardellina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
