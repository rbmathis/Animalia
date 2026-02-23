namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoungulata.Toxodontidae.Toxodon;

/// <summary>
/// Interface defining characteristics of Toxodon (genus).
/// </summary>
public interface IToxodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
