using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Pachytriton;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Pachytriton.unclassified_Pachytriton;

/// <summary>
/// Abstract class for unclassified Pachytriton (no rank).
/// NCBI TaxId: 2621867
/// </summary>
public abstract class unclassified_Pachytriton : Pachytriton, Iunclassified_Pachytriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pachytriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621867;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pachytriton";
}
