namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Opisthoproctus;

/// <summary>
/// Interface defining characteristics of Opisthoproctus (genus).
/// </summary>
public interface IOpisthoproctus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
