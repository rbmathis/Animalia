namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Fregetta;

/// <summary>
/// Interface defining characteristics of Fregetta (genus).
/// </summary>
public interface IFregetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
