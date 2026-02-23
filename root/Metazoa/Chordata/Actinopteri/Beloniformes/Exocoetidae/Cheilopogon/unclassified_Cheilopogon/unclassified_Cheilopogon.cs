using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Cheilopogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Cheilopogon.unclassified_Cheilopogon;

/// <summary>
/// Abstract class for unclassified Cheilopogon (no rank).
/// NCBI TaxId: 2640895
/// </summary>
public abstract class unclassified_Cheilopogon : Cheilopogon, Iunclassified_Cheilopogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cheilopogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640895;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cheilopogon";
}
