namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Lophophanes;

/// <summary>
/// Interface defining characteristics of Lophophanes (genus).
/// </summary>
public interface ILophophanes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
