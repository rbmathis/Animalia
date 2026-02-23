using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Taricha;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Taricha.unclassified_Taricha;

/// <summary>
/// Abstract class for unclassified Taricha (no rank).
/// NCBI TaxId: 2629677
/// </summary>
public abstract class unclassified_Taricha : Taricha, Iunclassified_Taricha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Taricha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629677;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Taricha";
}
