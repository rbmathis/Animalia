using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Parascaptor;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Parascaptor.unclassified_Parascaptor;

/// <summary>
/// Abstract class for unclassified Parascaptor (no rank).
/// NCBI TaxId: 2620149
/// </summary>
public abstract class unclassified_Parascaptor : Parascaptor, Iunclassified_Parascaptor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parascaptor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620149;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parascaptor";
}
