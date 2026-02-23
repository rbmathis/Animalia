using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Discogobio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Discogobio.unclassified_Discogobio;

/// <summary>
/// Abstract class for unclassified Discogobio (no rank).
/// NCBI TaxId: 2638983
/// </summary>
public abstract class unclassified_Discogobio : Discogobio, Iunclassified_Discogobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Discogobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638983;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Discogobio";
}
