namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Lagorchestes;

/// <summary>
/// Interface defining characteristics of Lagorchestes (genus).
/// </summary>
public interface ILagorchestes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
