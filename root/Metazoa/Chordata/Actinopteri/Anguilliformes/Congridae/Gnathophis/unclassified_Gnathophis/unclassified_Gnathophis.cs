using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Gnathophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Gnathophis.unclassified_Gnathophis;

/// <summary>
/// Abstract class for unclassified Gnathophis (no rank).
/// NCBI TaxId: 2644999
/// </summary>
public abstract class unclassified_Gnathophis : Gnathophis, Iunclassified_Gnathophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gnathophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644999;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gnathophis";
}
