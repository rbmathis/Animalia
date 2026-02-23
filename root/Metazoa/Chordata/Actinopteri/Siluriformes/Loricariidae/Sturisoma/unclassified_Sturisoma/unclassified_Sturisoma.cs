using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Sturisoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Sturisoma.unclassified_Sturisoma;

/// <summary>
/// Abstract class for unclassified Sturisoma (no rank).
/// NCBI TaxId: 2645568
/// </summary>
public abstract class unclassified_Sturisoma : Sturisoma, Iunclassified_Sturisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sturisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645568;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sturisoma";
}
