namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Plocepasser;

/// <summary>
/// Interface defining characteristics of Plocepasser (genus).
/// </summary>
public interface IPlocepasser
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
