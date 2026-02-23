namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Macropinna;

/// <summary>
/// Interface defining characteristics of Macropinna (genus).
/// </summary>
public interface IMacropinna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
