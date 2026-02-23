using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eumeces;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eumeces.unclassified_Eumeces;

/// <summary>
/// Abstract class for unclassified Eumeces (no rank).
/// NCBI TaxId: 2617810
/// </summary>
public abstract class unclassified_Eumeces : Eumeces, Iunclassified_Eumeces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eumeces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617810;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eumeces";
}
