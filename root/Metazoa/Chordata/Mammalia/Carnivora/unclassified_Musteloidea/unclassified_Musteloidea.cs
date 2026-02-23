using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.unclassified_Musteloidea;

/// <summary>
/// Abstract class for unclassified Musteloidea (no rank).
/// NCBI TaxId: 3072971
/// </summary>
public abstract class unclassified_Musteloidea : Carnivora, Iunclassified_Musteloidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Musteloidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3072971;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Musteloidea";
}
