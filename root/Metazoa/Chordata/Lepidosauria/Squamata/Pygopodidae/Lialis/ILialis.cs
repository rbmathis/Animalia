namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae.Lialis;

/// <summary>
/// Interface defining characteristics of Lialis (genus).
/// </summary>
public interface ILialis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
