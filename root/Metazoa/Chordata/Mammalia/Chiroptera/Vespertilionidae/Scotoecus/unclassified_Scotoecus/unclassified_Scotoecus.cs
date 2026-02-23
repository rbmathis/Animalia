using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Scotoecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Scotoecus.unclassified_Scotoecus;

/// <summary>
/// Abstract class for unclassified Scotoecus (no rank).
/// NCBI TaxId: 2636109
/// </summary>
public abstract class unclassified_Scotoecus : Scotoecus, Iunclassified_Scotoecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scotoecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636109;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scotoecus";
}
