using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Nannostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Nannostomus.unclassified_Nannostomus;

/// <summary>
/// Abstract class for unclassified Nannostomus (no rank).
/// NCBI TaxId: 2625929
/// </summary>
public abstract class unclassified_Nannostomus : Nannostomus, Iunclassified_Nannostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625929;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannostomus";
}
