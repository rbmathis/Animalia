namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Sturisomatichthys;

/// <summary>
/// Interface defining characteristics of Sturisomatichthys (genus).
/// </summary>
public interface ISturisomatichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
