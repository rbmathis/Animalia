using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.unclassified_Schizothoracinae;

/// <summary>
/// Abstract class for unclassified Schizothoracinae (no rank).
/// NCBI TaxId: 2721538
/// </summary>
public abstract class unclassified_Schizothoracinae : Cyprinidae, Iunclassified_Schizothoracinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schizothoracinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2721538;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schizothoracinae";
}
