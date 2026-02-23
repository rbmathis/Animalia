using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Caesio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Caesio.unclassified_Caesio;

/// <summary>
/// Abstract class for unclassified Caesio (no rank).
/// NCBI TaxId: 2636887
/// </summary>
public abstract class unclassified_Caesio : Caesio, Iunclassified_Caesio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caesio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636887;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caesio";
}
