namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Onychostruthus;

/// <summary>
/// Interface defining characteristics of Onychostruthus (genus).
/// </summary>
public interface IOnychostruthus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
