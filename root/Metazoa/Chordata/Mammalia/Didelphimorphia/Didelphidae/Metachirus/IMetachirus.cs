namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Metachirus;

/// <summary>
/// Interface defining characteristics of Metachirus (genus).
/// </summary>
public interface IMetachirus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
