using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Sturisomatichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Sturisomatichthys.unclassified_Sturisomatichthys;

/// <summary>
/// Abstract class for unclassified Sturisomatichthys (no rank).
/// NCBI TaxId: 2954777
/// </summary>
public abstract class unclassified_Sturisomatichthys : Sturisomatichthys, Iunclassified_Sturisomatichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sturisomatichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2954777;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sturisomatichthys";
}
