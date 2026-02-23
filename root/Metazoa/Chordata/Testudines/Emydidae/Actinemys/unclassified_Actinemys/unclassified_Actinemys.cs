using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Actinemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Actinemys.unclassified_Actinemys;

/// <summary>
/// Abstract class for unclassified Actinemys (no rank).
/// NCBI TaxId: 2876990
/// </summary>
public abstract class unclassified_Actinemys : Actinemys, Iunclassified_Actinemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Actinemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2876990;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Actinemys";
}
