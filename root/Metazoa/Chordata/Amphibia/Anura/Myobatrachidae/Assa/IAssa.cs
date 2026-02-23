namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Assa;

/// <summary>
/// Interface defining characteristics of Assa (genus).
/// </summary>
public interface IAssa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
