using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hemiculter;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hemiculter.unclassified_Hemiculter;

/// <summary>
/// Abstract class for unclassified Hemiculter (no rank).
/// NCBI TaxId: 2648020
/// </summary>
public abstract class unclassified_Hemiculter : Hemiculter, Iunclassified_Hemiculter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemiculter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648020;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemiculter";
}
