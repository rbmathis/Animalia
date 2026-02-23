using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Ara;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Ara.unclassified_Ara;

/// <summary>
/// Abstract class for unclassified Ara (no rank).
/// NCBI TaxId: 2635732
/// </summary>
public abstract class unclassified_Ara : Ara, Iunclassified_Ara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635732;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ara";
}
