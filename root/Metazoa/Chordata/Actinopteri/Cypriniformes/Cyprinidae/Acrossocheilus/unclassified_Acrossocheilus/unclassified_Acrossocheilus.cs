using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Acrossocheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Acrossocheilus.unclassified_Acrossocheilus;

/// <summary>
/// Abstract class for unclassified Acrossocheilus (no rank).
/// NCBI TaxId: 2617881
/// </summary>
public abstract class unclassified_Acrossocheilus : Acrossocheilus, Iunclassified_Acrossocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acrossocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617881;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acrossocheilus";
}
