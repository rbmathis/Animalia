using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Akodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Akodon.unclassified_Akodon;

/// <summary>
/// Abstract class for unclassified Akodon (no rank).
/// NCBI TaxId: 2629051
/// </summary>
public abstract class unclassified_Akodon : Akodon, Iunclassified_Akodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Akodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629051;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Akodon";
}
