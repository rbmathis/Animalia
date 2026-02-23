namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Tlacuatzin;

/// <summary>
/// Interface defining characteristics of Tlacuatzin (genus).
/// </summary>
public interface ITlacuatzin
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
