using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Cabdio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Cabdio.unclassified_Cabdio;

/// <summary>
/// Abstract class for unclassified Cabdio (no rank).
/// NCBI TaxId: 2637231
/// </summary>
public abstract class unclassified_Cabdio : Cabdio, Iunclassified_Cabdio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cabdio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637231;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cabdio";
}
