using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Ophisternon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Ophisternon.unclassified_Ophisternon;

/// <summary>
/// Abstract class for unclassified Ophisternon (no rank).
/// NCBI TaxId: 2685184
/// </summary>
public abstract class unclassified_Ophisternon : Ophisternon, Iunclassified_Ophisternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophisternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685184;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophisternon";
}
