namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Stipiturus;

/// <summary>
/// Interface defining characteristics of Stipiturus (genus).
/// </summary>
public interface IStipiturus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
