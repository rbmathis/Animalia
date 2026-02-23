using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Schizopygopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Schizopygopsis.unclassified_Schizopygopsis;

/// <summary>
/// Abstract class for unclassified Schizopygopsis (no rank).
/// NCBI TaxId: 2639892
/// </summary>
public abstract class unclassified_Schizopygopsis : Schizopygopsis, Iunclassified_Schizopygopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schizopygopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639892;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schizopygopsis";
}
