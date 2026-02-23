namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Retropinnidae.Retropinna;

/// <summary>
/// Interface defining characteristics of Retropinna (genus).
/// </summary>
public interface IRetropinna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
