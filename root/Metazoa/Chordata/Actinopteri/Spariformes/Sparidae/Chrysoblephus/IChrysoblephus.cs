namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Chrysoblephus;

/// <summary>
/// Interface defining characteristics of Chrysoblephus (genus).
/// </summary>
public interface IChrysoblephus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
