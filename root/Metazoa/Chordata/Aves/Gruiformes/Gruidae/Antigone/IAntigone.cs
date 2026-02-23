namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Antigone;

/// <summary>
/// Interface defining characteristics of Antigone (genus).
/// </summary>
public interface IAntigone
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
