using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.unclassified_Caprimulgiformes;

/// <summary>
/// Abstract class for unclassified Caprimulgiformes (no rank).
/// NCBI TaxId: 791162
/// </summary>
public abstract class unclassified_Caprimulgiformes : Caprimulgiformes, Iunclassified_Caprimulgiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caprimulgiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 791162;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caprimulgiformes";
}
