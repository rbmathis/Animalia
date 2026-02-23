using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Epactionotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Epactionotus.unclassified_Epactionotus;

/// <summary>
/// Abstract class for unclassified Epactionotus (no rank).
/// NCBI TaxId: 2739220
/// </summary>
public abstract class unclassified_Epactionotus : Epactionotus, Iunclassified_Epactionotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epactionotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2739220;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epactionotus";
}
