namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Hemerocoetes;

/// <summary>
/// Interface defining characteristics of Hemerocoetes (genus).
/// </summary>
public interface IHemerocoetes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
