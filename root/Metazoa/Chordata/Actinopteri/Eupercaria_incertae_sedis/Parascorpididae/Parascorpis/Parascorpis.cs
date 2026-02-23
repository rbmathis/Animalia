using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Parascorpididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Parascorpididae.Parascorpis;

/// <summary>
/// Abstract class for Parascorpis (genus).
/// NCBI TaxId: 1003986
/// </summary>
public abstract class Parascorpis : Parascorpididae, IParascorpis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parascorpis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003986;

    /// <inheritdoc />
    public virtual string GenusName => "Parascorpis";

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
