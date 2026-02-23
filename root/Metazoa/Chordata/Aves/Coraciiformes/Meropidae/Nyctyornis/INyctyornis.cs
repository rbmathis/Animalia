namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Meropidae.Nyctyornis;

/// <summary>
/// Interface defining characteristics of Nyctyornis (genus).
/// </summary>
public interface INyctyornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
