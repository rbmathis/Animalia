namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Adenomus;

/// <summary>
/// Interface defining characteristics of Adenomus (genus).
/// </summary>
public interface IAdenomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
