using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Tetracheilostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Tetracheilostoma.unclassified_Tetracheilostoma;

/// <summary>
/// Abstract class for unclassified Tetracheilostoma (no rank).
/// NCBI TaxId: 2628894
/// </summary>
public abstract class unclassified_Tetracheilostoma : Tetracheilostoma, Iunclassified_Tetracheilostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tetracheilostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tetracheilostoma";
}
