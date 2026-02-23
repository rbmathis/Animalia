using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Peprilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Peprilus.unclassified_Peprilus;

/// <summary>
/// Abstract class for unclassified Peprilus (no rank).
/// NCBI TaxId: 2821162
/// </summary>
public abstract class unclassified_Peprilus : Peprilus, Iunclassified_Peprilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Peprilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821162;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Peprilus";
}
