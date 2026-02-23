using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Hassar;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Hassar.unclassified_Hassar;

/// <summary>
/// Abstract class for unclassified Hassar (no rank).
/// NCBI TaxId: 2647413
/// </summary>
public abstract class unclassified_Hassar : Hassar, Iunclassified_Hassar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hassar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647413;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hassar";
}
