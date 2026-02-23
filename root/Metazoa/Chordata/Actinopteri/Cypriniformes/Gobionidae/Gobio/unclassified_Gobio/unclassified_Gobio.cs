using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobio.unclassified_Gobio;

/// <summary>
/// Abstract class for unclassified Gobio (no rank).
/// NCBI TaxId: 2646418
/// </summary>
public abstract class unclassified_Gobio : Gobio, Iunclassified_Gobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646418;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobio";
}
