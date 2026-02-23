using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Liua;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Liua.unclassified_Liua_in_salamanders;

/// <summary>
/// Abstract class for unclassified Liua (in: salamanders) (no rank).
/// NCBI TaxId: 2677607
/// </summary>
public abstract class unclassified_Liua_in_salamanders : Liua, Iunclassified_Liua_in_salamanders
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liua (in: salamanders)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677607;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liua_in_salamanders";
}
