namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Leptobrachella;

/// <summary>
/// Interface defining characteristics of Leptobrachella (genus).
/// </summary>
public interface ILeptobrachella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
