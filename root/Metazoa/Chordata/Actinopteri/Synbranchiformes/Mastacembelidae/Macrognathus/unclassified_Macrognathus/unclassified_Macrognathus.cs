using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae.Macrognathus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae.Macrognathus.unclassified_Macrognathus;

/// <summary>
/// Abstract class for unclassified Macrognathus (no rank).
/// NCBI TaxId: 2644487
/// </summary>
public abstract class unclassified_Macrognathus : Macrognathus, Iunclassified_Macrognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macrognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644487;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macrognathus";
}
