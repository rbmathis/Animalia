using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae.Cyttopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae.Cyttopsis.unclassified_Cyttopsis;

/// <summary>
/// Abstract class for unclassified Cyttopsis (no rank).
/// NCBI TaxId: 2642416
/// </summary>
public abstract class unclassified_Cyttopsis : Cyttopsis, Iunclassified_Cyttopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyttopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642416;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyttopsis";
}
