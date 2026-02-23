using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Romanogobio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Romanogobio.unclassified_Romanogobio;

/// <summary>
/// Abstract class for unclassified Romanogobio (no rank).
/// NCBI TaxId: 2641375
/// </summary>
public abstract class unclassified_Romanogobio : Romanogobio, Iunclassified_Romanogobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Romanogobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641375;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Romanogobio";
}
