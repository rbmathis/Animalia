namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Lathrotriccus;

/// <summary>
/// Interface defining characteristics of Lathrotriccus (genus).
/// </summary>
public interface ILathrotriccus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
