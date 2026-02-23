namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Sommeromys;

/// <summary>
/// Interface defining characteristics of Sommeromys (genus).
/// </summary>
public interface ISommeromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
