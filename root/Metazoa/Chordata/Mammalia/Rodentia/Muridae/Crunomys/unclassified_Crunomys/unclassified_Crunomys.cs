using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crunomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crunomys.unclassified_Crunomys;

/// <summary>
/// Abstract class for unclassified Crunomys (no rank).
/// NCBI TaxId: 3391937
/// </summary>
public abstract class unclassified_Crunomys : Crunomys, Iunclassified_Crunomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crunomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3391937;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crunomys";
}
