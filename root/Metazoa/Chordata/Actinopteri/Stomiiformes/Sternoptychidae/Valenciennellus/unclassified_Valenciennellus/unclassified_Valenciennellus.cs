using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Valenciennellus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Valenciennellus.unclassified_Valenciennellus;

/// <summary>
/// Abstract class for unclassified Valenciennellus (no rank).
/// NCBI TaxId: 2633126
/// </summary>
public abstract class unclassified_Valenciennellus : Valenciennellus, Iunclassified_Valenciennellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Valenciennellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633126;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Valenciennellus";
}
