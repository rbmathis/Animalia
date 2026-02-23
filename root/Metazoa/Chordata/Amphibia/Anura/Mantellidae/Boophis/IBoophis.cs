namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Boophis;

/// <summary>
/// Interface defining characteristics of Boophis (genus).
/// </summary>
public interface IBoophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
