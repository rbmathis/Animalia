using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Hydropsalis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Hydropsalis.unclassified_Hydropsalis;

/// <summary>
/// Abstract class for unclassified Hydropsalis (no rank).
/// NCBI TaxId: 2646529
/// </summary>
public abstract class unclassified_Hydropsalis : Hydropsalis, Iunclassified_Hydropsalis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hydropsalis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646529;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hydropsalis";
}
