using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Sinogastromyzon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Sinogastromyzon.unclassified_Sinogastromyzon;

/// <summary>
/// Abstract class for unclassified Sinogastromyzon (no rank).
/// NCBI TaxId: 2638528
/// </summary>
public abstract class unclassified_Sinogastromyzon : Sinogastromyzon, Iunclassified_Sinogastromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sinogastromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638528;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sinogastromyzon";
}
