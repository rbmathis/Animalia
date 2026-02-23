using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Epipedobates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Epipedobates.unclassified_Epipedobates;

/// <summary>
/// Abstract class for unclassified Epipedobates (no rank).
/// NCBI TaxId: 2619170
/// </summary>
public abstract class unclassified_Epipedobates : Epipedobates, Iunclassified_Epipedobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epipedobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619170;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epipedobates";
}
