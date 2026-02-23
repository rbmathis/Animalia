using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Bagarius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Bagarius.unclassified_Bagarius;

/// <summary>
/// Abstract class for unclassified Bagarius (no rank).
/// NCBI TaxId: 3424834
/// </summary>
public abstract class unclassified_Bagarius : Bagarius, Iunclassified_Bagarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bagarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3424834;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bagarius";
}
