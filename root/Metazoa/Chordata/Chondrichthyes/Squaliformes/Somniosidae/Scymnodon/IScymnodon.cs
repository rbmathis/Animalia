namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Scymnodon;

/// <summary>
/// Interface defining characteristics of Scymnodon (genus).
/// </summary>
public interface IScymnodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
