using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Microphysogobio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Microphysogobio.unclassified_Microphysogobio;

/// <summary>
/// Abstract class for unclassified Microphysogobio (no rank).
/// NCBI TaxId: 2624887
/// </summary>
public abstract class unclassified_Microphysogobio : Microphysogobio, Iunclassified_Microphysogobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microphysogobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624887;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microphysogobio";
}
