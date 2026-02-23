namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Petrophassa;

/// <summary>
/// Interface defining characteristics of Petrophassa (genus).
/// </summary>
public interface IPetrophassa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
