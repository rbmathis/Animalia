namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Halocynthia;

/// <summary>
/// Interface defining characteristics of Halocynthia (genus).
/// </summary>
public interface IHalocynthia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
