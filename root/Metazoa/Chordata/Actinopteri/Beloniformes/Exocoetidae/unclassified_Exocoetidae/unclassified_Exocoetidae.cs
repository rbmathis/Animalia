using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.unclassified_Exocoetidae;

/// <summary>
/// Abstract class for unclassified Exocoetidae (no rank).
/// NCBI TaxId: 741674
/// </summary>
public abstract class unclassified_Exocoetidae : Exocoetidae, Iunclassified_Exocoetidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Exocoetidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 741674;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Exocoetidae";
}
