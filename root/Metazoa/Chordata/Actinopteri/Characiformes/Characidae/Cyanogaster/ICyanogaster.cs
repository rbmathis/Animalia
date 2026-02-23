namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cyanogaster;

/// <summary>
/// Interface defining characteristics of Cyanogaster (genus).
/// </summary>
public interface ICyanogaster
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
