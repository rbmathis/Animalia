using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae.Mastacembelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae.Mastacembelus.unclassified_Mastacembelus;

/// <summary>
/// Abstract class for unclassified Mastacembelus (no rank).
/// NCBI TaxId: 2631391
/// </summary>
public abstract class unclassified_Mastacembelus : Mastacembelus, Iunclassified_Mastacembelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mastacembelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631391;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mastacembelus";
}
