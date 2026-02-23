using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Chrysemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Chrysemys.unclassified_Chrysemys;

/// <summary>
/// Abstract class for unclassified Chrysemys (no rank).
/// NCBI TaxId: 2625313
/// </summary>
public abstract class unclassified_Chrysemys : Chrysemys, Iunclassified_Chrysemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chrysemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625313;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chrysemys";
}
