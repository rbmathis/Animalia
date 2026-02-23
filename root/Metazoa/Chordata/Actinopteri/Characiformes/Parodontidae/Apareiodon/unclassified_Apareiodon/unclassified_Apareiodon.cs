using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae.Apareiodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae.Apareiodon.unclassified_Apareiodon;

/// <summary>
/// Abstract class for unclassified Apareiodon (no rank).
/// NCBI TaxId: 2648007
/// </summary>
public abstract class unclassified_Apareiodon : Apareiodon, Iunclassified_Apareiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apareiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648007;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apareiodon";
}
