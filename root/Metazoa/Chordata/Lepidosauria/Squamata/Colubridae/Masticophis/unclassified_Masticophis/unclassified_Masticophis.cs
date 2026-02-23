using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Masticophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Masticophis.unclassified_Masticophis;

/// <summary>
/// Abstract class for unclassified Masticophis (no rank).
/// NCBI TaxId: 2878399
/// </summary>
public abstract class unclassified_Masticophis : Masticophis, Iunclassified_Masticophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Masticophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878399;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Masticophis";
}
