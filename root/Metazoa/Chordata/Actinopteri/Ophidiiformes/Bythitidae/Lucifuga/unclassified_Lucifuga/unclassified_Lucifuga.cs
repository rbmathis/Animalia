using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Lucifuga;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Lucifuga.unclassified_Lucifuga;

/// <summary>
/// Abstract class for unclassified Lucifuga (no rank).
/// NCBI TaxId: 2624182
/// </summary>
public abstract class unclassified_Lucifuga : Lucifuga, Iunclassified_Lucifuga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lucifuga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624182;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lucifuga";
}
