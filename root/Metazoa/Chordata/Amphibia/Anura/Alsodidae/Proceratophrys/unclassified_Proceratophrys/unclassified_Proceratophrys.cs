using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Proceratophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Proceratophrys.unclassified_Proceratophrys;

/// <summary>
/// Abstract class for unclassified Proceratophrys (no rank).
/// NCBI TaxId: 2647673
/// </summary>
public abstract class unclassified_Proceratophrys : Proceratophrys, Iunclassified_Proceratophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Proceratophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647673;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Proceratophrys";
}
