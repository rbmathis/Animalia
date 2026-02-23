using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Meristogenys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Meristogenys.unclassified_Meristogenys;

/// <summary>
/// Abstract class for unclassified Meristogenys (no rank).
/// NCBI TaxId: 2628090
/// </summary>
public abstract class unclassified_Meristogenys : Meristogenys, Iunclassified_Meristogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Meristogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628090;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Meristogenys";
}
