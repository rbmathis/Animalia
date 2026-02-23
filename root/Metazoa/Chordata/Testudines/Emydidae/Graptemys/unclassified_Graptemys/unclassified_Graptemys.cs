using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys.unclassified_Graptemys;

/// <summary>
/// Abstract class for unclassified Graptemys (no rank).
/// NCBI TaxId: 2623687
/// </summary>
public abstract class unclassified_Graptemys : Graptemys, Iunclassified_Graptemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Graptemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623687;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Graptemys";
}
