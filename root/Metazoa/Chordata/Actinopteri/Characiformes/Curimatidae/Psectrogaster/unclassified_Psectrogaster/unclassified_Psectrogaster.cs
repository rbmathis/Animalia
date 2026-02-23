using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Psectrogaster;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Psectrogaster.unclassified_Psectrogaster;

/// <summary>
/// Abstract class for unclassified Psectrogaster (no rank).
/// NCBI TaxId: 2710731
/// </summary>
public abstract class unclassified_Psectrogaster : Psectrogaster, Iunclassified_Psectrogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psectrogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2710731;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psectrogaster";
}
