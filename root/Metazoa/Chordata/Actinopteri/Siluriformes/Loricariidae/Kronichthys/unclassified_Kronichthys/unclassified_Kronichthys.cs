using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Kronichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Kronichthys.unclassified_Kronichthys;

/// <summary>
/// Abstract class for unclassified Kronichthys (no rank).
/// NCBI TaxId: 2643530
/// </summary>
public abstract class unclassified_Kronichthys : Kronichthys, Iunclassified_Kronichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kronichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643530;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kronichthys";
}
