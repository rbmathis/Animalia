using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trimmatom;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trimmatom.unclassified_Trimmatom;

/// <summary>
/// Abstract class for unclassified Trimmatom (no rank).
/// NCBI TaxId: 2620281
/// </summary>
public abstract class unclassified_Trimmatom : Trimmatom, Iunclassified_Trimmatom
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trimmatom";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620281;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trimmatom";
}
