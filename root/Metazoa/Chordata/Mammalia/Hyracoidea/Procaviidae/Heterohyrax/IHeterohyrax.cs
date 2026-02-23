namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae.Heterohyrax;

/// <summary>
/// Interface defining characteristics of Heterohyrax (genus).
/// </summary>
public interface IHeterohyrax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
