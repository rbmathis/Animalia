namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Petrodromus;

/// <summary>
/// Interface defining characteristics of Petrodromus (genus).
/// </summary>
public interface IPetrodromus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
