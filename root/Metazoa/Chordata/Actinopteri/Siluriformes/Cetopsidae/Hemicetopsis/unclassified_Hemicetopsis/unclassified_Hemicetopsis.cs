using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Hemicetopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Hemicetopsis.unclassified_Hemicetopsis;

/// <summary>
/// Abstract class for unclassified Hemicetopsis (no rank).
/// NCBI TaxId: 2621266
/// </summary>
public abstract class unclassified_Hemicetopsis : Hemicetopsis, Iunclassified_Hemicetopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemicetopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621266;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemicetopsis";
}
