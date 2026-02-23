using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobionidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobionidae_incertae_sedis.Coreius;

/// <summary>
/// Abstract class for Coreius (genus).
/// NCBI TaxId: 171524
/// </summary>
public abstract class Coreius : Gobionidae_incertae_sedis, ICoreius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coreius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171524;

    /// <inheritdoc />
    public virtual string GenusName => "Coreius";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
