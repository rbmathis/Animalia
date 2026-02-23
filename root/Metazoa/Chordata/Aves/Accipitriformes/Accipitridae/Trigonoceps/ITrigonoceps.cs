namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Trigonoceps;

/// <summary>
/// Interface defining characteristics of Trigonoceps (genus).
/// </summary>
public interface ITrigonoceps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
