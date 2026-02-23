namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Bolyeridae.Casarea;

/// <summary>
/// Interface defining characteristics of Casarea (genus).
/// </summary>
public interface ICasarea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
