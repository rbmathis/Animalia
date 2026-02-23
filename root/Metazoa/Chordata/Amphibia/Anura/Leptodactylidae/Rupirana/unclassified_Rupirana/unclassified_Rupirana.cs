using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Rupirana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Rupirana.unclassified_Rupirana;

/// <summary>
/// Abstract class for unclassified Rupirana (no rank).
/// NCBI TaxId: 3400715
/// </summary>
public abstract class unclassified_Rupirana : Rupirana, Iunclassified_Rupirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rupirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3400715;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rupirana";
}
