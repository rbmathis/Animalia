namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Hoplocharax;

/// <summary>
/// Interface defining characteristics of Hoplocharax (genus).
/// </summary>
public interface IHoplocharax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
