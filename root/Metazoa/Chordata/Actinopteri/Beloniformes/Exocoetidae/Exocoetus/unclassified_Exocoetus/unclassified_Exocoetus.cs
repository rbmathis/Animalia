using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Exocoetus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Exocoetus.unclassified_Exocoetus;

/// <summary>
/// Abstract class for unclassified Exocoetus (no rank).
/// NCBI TaxId: 3240757
/// </summary>
public abstract class unclassified_Exocoetus : Exocoetus, Iunclassified_Exocoetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Exocoetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3240757;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Exocoetus";
}
