using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Palaeoloxodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Palaeoloxodon.unclassified_Palaeoloxodon;

/// <summary>
/// Abstract class for unclassified Palaeoloxodon (no rank).
/// NCBI TaxId: 3064005
/// </summary>
public abstract class unclassified_Palaeoloxodon : Palaeoloxodon, Iunclassified_Palaeoloxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Palaeoloxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3064005;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Palaeoloxodon";
}
