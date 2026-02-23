using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Notropis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Notropis.unclassified_Notropis;

/// <summary>
/// Abstract class for unclassified Notropis (no rank).
/// NCBI TaxId: 2635397
/// </summary>
public abstract class unclassified_Notropis : Notropis, Iunclassified_Notropis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Notropis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635397;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Notropis";
}
