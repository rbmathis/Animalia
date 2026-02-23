namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Taphozous;

/// <summary>
/// Interface defining characteristics of Taphozous (genus).
/// </summary>
public interface ITaphozous
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
