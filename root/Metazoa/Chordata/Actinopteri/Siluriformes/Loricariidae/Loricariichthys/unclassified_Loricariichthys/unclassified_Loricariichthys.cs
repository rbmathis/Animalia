using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricariichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricariichthys.unclassified_Loricariichthys;

/// <summary>
/// Abstract class for unclassified Loricariichthys (no rank).
/// NCBI TaxId: 2627841
/// </summary>
public abstract class unclassified_Loricariichthys : Loricariichthys, Iunclassified_Loricariichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Loricariichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627841;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Loricariichthys";
}
