namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae.Caenotropus;

/// <summary>
/// Interface defining characteristics of Caenotropus (genus).
/// </summary>
public interface ICaenotropus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
