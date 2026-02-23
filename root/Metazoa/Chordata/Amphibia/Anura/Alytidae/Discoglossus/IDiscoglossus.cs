namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Discoglossus;

/// <summary>
/// Interface defining characteristics of Discoglossus (genus).
/// </summary>
public interface IDiscoglossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
