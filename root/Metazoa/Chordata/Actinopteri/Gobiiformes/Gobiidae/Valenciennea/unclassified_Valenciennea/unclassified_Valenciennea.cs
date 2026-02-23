using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Valenciennea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Valenciennea.unclassified_Valenciennea;

/// <summary>
/// Abstract class for unclassified Valenciennea (no rank).
/// NCBI TaxId: 2990108
/// </summary>
public abstract class unclassified_Valenciennea : Valenciennea, Iunclassified_Valenciennea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Valenciennea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990108;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Valenciennea";
}
