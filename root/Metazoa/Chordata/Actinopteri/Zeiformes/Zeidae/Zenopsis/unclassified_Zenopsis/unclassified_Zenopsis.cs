using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae.Zenopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae.Zenopsis.unclassified_Zenopsis;

/// <summary>
/// Abstract class for unclassified Zenopsis (no rank).
/// NCBI TaxId: 3469418
/// </summary>
public abstract class unclassified_Zenopsis : Zenopsis, Iunclassified_Zenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3469418;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zenopsis";
}
