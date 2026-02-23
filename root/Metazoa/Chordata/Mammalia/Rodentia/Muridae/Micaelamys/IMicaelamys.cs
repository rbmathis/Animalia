namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Micaelamys;

/// <summary>
/// Interface defining characteristics of Micaelamys (genus).
/// </summary>
public interface IMicaelamys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
