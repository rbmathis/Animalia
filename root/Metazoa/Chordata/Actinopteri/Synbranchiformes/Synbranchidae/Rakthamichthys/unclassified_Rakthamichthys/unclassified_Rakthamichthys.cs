using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Rakthamichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Rakthamichthys.unclassified_Rakthamichthys;

/// <summary>
/// Abstract class for unclassified Rakthamichthys (no rank).
/// NCBI TaxId: 2852092
/// </summary>
public abstract class unclassified_Rakthamichthys : Rakthamichthys, Iunclassified_Rakthamichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rakthamichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2852092;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rakthamichthys";
}
