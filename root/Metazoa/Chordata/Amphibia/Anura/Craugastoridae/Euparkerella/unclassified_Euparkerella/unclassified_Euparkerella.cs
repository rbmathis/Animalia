using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Euparkerella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Euparkerella.unclassified_Euparkerella;

/// <summary>
/// Abstract class for unclassified Euparkerella (no rank).
/// NCBI TaxId: 2630515
/// </summary>
public abstract class unclassified_Euparkerella : Euparkerella, Iunclassified_Euparkerella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Euparkerella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630515;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Euparkerella";
}
