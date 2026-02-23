namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Pedostibes;

/// <summary>
/// Interface defining characteristics of Pedostibes (genus).
/// </summary>
public interface IPedostibes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
