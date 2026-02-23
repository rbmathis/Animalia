namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoryctemorphia.Notoryctidae.Notoryctes;

/// <summary>
/// Interface defining characteristics of Notoryctes (genus).
/// </summary>
public interface INotoryctes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
