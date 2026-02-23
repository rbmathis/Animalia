using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Karstsinnectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Karstsinnectes.unclassified_Karstsinnectes;

/// <summary>
/// Abstract class for unclassified Karstsinnectes (no rank).
/// NCBI TaxId: 3109567
/// </summary>
public abstract class unclassified_Karstsinnectes : Karstsinnectes, Iunclassified_Karstsinnectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Karstsinnectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3109567;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Karstsinnectes";
}
