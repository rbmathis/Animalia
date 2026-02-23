namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Myersiella;

/// <summary>
/// Interface defining characteristics of Myersiella (genus).
/// </summary>
public interface IMyersiella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
