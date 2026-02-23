using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Euroscaptor;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Euroscaptor.unclassified_Euroscaptor;

/// <summary>
/// Abstract class for unclassified Euroscaptor (no rank).
/// NCBI TaxId: 2647770
/// </summary>
public abstract class unclassified_Euroscaptor : Euroscaptor, Iunclassified_Euroscaptor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Euroscaptor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647770;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Euroscaptor";
}
