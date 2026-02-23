using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Hapalogenyidae.Hapalogenys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Hapalogenyidae.Hapalogenys.unclassified_Hapalogenys;

/// <summary>
/// Abstract class for unclassified Hapalogenys (no rank).
/// NCBI TaxId: 2618580
/// </summary>
public abstract class unclassified_Hapalogenys : Hapalogenys, Iunclassified_Hapalogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hapalogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618580;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hapalogenys";
}
