namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranixalidae.Walkerana;

/// <summary>
/// Interface defining characteristics of Walkerana (genus).
/// </summary>
public interface IWalkerana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
