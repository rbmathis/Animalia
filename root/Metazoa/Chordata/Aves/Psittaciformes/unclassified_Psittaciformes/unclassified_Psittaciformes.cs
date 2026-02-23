using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.unclassified_Psittaciformes;

/// <summary>
/// Abstract class for unclassified Psittaciformes (no rank).
/// NCBI TaxId: 772031
/// </summary>
public abstract class unclassified_Psittaciformes : Psittaciformes, Iunclassified_Psittaciformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psittaciformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 772031;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psittaciformes";
}
