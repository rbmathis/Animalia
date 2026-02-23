using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Caudacaecilia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Caudacaecilia.unclassified_Caudacaecilia;

/// <summary>
/// Abstract class for unclassified Caudacaecilia (no rank).
/// NCBI TaxId: 2643602
/// </summary>
public abstract class unclassified_Caudacaecilia : Caudacaecilia, Iunclassified_Caudacaecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caudacaecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643602;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caudacaecilia";
}
