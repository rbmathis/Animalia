using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.unclassified_Apodiformes;

/// <summary>
/// Abstract class for unclassified Apodiformes (no rank).
/// NCBI TaxId: 771902
/// </summary>
public abstract class unclassified_Apodiformes : Apodiformes, Iunclassified_Apodiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apodiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 771902;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apodiformes";
}
