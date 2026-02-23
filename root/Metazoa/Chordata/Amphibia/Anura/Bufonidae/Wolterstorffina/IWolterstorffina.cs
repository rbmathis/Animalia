namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Wolterstorffina;

/// <summary>
/// Interface defining characteristics of Wolterstorffina (genus).
/// </summary>
public interface IWolterstorffina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
