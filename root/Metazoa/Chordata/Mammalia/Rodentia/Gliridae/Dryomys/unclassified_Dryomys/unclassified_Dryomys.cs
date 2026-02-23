using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Dryomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Dryomys.unclassified_Dryomys;

/// <summary>
/// Abstract class for unclassified Dryomys (no rank).
/// NCBI TaxId: 2629648
/// </summary>
public abstract class unclassified_Dryomys : Dryomys, Iunclassified_Dryomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dryomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629648;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dryomys";
}
