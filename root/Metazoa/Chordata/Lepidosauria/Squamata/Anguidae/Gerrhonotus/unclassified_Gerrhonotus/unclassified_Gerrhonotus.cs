using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Gerrhonotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Gerrhonotus.unclassified_Gerrhonotus;

/// <summary>
/// Abstract class for unclassified Gerrhonotus (no rank).
/// NCBI TaxId: 2218528
/// </summary>
public abstract class unclassified_Gerrhonotus : Gerrhonotus, Iunclassified_Gerrhonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gerrhonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2218528;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gerrhonotus";
}
