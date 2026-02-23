using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sinocrossocheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sinocrossocheilus.unclassified_Sinocrossocheilus;

/// <summary>
/// Abstract class for unclassified Sinocrossocheilus (no rank).
/// NCBI TaxId: 2626828
/// </summary>
public abstract class unclassified_Sinocrossocheilus : Sinocrossocheilus, Iunclassified_Sinocrossocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sinocrossocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626828;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sinocrossocheilus";
}
