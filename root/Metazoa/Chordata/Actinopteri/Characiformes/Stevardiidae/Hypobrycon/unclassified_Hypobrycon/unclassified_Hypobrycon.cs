using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Hypobrycon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Hypobrycon.unclassified_Hypobrycon;

/// <summary>
/// Abstract class for unclassified Hypobrycon (no rank).
/// NCBI TaxId: 2631906
/// </summary>
public abstract class unclassified_Hypobrycon : Hypobrycon, Iunclassified_Hypobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631906;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypobrycon";
}
