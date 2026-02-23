using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Xenisthmidae.Tyson;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Xenisthmidae.Tyson.unclassified_Tyson;

/// <summary>
/// Abstract class for unclassified Tyson (no rank).
/// NCBI TaxId: 2631041
/// </summary>
public abstract class unclassified_Tyson : Tyson, Iunclassified_Tyson
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tyson";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631041;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tyson";
}
