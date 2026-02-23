using AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Branchiostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Branchiostoma.unclassified_Branchiostoma;

/// <summary>
/// Abstract class for unclassified Branchiostoma (no rank).
/// NCBI TaxId: 2639570
/// </summary>
public abstract class unclassified_Branchiostoma : Branchiostoma, Iunclassified_Branchiostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Branchiostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639570;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Branchiostoma";
}
