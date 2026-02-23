using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Scyliorhinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Scyliorhinus.unclassified_Scyliorhinus;

/// <summary>
/// Abstract class for unclassified Scyliorhinus (no rank).
/// NCBI TaxId: 2646949
/// </summary>
public abstract class unclassified_Scyliorhinus : Scyliorhinus, Iunclassified_Scyliorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scyliorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646949;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scyliorhinus";
}
