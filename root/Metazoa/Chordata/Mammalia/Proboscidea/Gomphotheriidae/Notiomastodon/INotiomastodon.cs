namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Gomphotheriidae.Notiomastodon;

/// <summary>
/// Interface defining characteristics of Notiomastodon (genus).
/// </summary>
public interface INotiomastodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
