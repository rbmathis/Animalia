using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Psenopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Psenopsis.unclassified_Psenopsis;

/// <summary>
/// Abstract class for unclassified Psenopsis (no rank).
/// NCBI TaxId: 2649002
/// </summary>
public abstract class unclassified_Psenopsis : Psenopsis, Iunclassified_Psenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649002;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psenopsis";
}
