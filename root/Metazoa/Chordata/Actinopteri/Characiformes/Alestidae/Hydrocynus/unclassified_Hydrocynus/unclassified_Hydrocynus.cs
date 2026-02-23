using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Hydrocynus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Hydrocynus.unclassified_Hydrocynus;

/// <summary>
/// Abstract class for unclassified Hydrocynus (no rank).
/// NCBI TaxId: 2684989
/// </summary>
public abstract class unclassified_Hydrocynus : Hydrocynus, Iunclassified_Hydrocynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hydrocynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684989;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hydrocynus";
}
