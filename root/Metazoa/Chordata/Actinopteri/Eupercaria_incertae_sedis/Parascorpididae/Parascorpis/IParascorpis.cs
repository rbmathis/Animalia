namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Parascorpididae.Parascorpis;

/// <summary>
/// Interface defining characteristics of Parascorpis (genus).
/// </summary>
public interface IParascorpis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
