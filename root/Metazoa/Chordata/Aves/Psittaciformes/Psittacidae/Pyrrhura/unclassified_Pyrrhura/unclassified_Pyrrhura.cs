using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pyrrhura;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pyrrhura.unclassified_Pyrrhura;

/// <summary>
/// Abstract class for unclassified Pyrrhura (no rank).
/// NCBI TaxId: 2797228
/// </summary>
public abstract class unclassified_Pyrrhura : Pyrrhura, Iunclassified_Pyrrhura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyrrhura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2797228;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyrrhura";
}
