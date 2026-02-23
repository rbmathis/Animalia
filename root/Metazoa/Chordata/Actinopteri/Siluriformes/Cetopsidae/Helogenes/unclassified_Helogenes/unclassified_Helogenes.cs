using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Helogenes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Helogenes.unclassified_Helogenes;

/// <summary>
/// Abstract class for unclassified Helogenes (no rank).
/// NCBI TaxId: 2647700
/// </summary>
public abstract class unclassified_Helogenes : Helogenes, Iunclassified_Helogenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Helogenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647700;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Helogenes";
}
