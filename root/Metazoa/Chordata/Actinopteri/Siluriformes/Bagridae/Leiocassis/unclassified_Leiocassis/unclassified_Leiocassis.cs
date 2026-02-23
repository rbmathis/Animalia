using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Leiocassis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Leiocassis.unclassified_Leiocassis;

/// <summary>
/// Abstract class for unclassified Leiocassis (no rank).
/// NCBI TaxId: 2642788
/// </summary>
public abstract class unclassified_Leiocassis : Leiocassis, Iunclassified_Leiocassis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leiocassis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642788;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leiocassis";
}
