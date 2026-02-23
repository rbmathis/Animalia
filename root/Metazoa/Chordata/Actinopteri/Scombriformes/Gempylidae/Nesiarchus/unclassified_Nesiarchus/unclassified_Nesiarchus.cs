using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Nesiarchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Nesiarchus.unclassified_Nesiarchus;

/// <summary>
/// Abstract class for unclassified Nesiarchus (no rank).
/// NCBI TaxId: 3031679
/// </summary>
public abstract class unclassified_Nesiarchus : Nesiarchus, Iunclassified_Nesiarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nesiarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3031679;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nesiarchus";
}
