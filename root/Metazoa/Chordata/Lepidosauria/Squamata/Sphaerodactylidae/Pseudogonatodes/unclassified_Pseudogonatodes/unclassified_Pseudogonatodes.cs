using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Pseudogonatodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Pseudogonatodes.unclassified_Pseudogonatodes;

/// <summary>
/// Abstract class for unclassified Pseudogonatodes (no rank).
/// NCBI TaxId: 3115356
/// </summary>
public abstract class unclassified_Pseudogonatodes : Pseudogonatodes, Iunclassified_Pseudogonatodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudogonatodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3115356;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudogonatodes";
}
