using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobionellus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobionellus.unclassified_Gobionellus;

/// <summary>
/// Abstract class for unclassified Gobionellus (no rank).
/// NCBI TaxId: 2624647
/// </summary>
public abstract class unclassified_Gobionellus : Gobionellus, Iunclassified_Gobionellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobionellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624647;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobionellus";
}
