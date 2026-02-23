namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Tytonidae.Tyto;

/// <summary>
/// Interface defining characteristics of Tyto (genus).
/// </summary>
public interface ITyto
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
