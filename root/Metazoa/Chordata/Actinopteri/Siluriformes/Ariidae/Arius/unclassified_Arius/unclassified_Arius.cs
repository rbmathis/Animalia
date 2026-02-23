using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Arius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Arius.unclassified_Arius;

/// <summary>
/// Abstract class for unclassified Arius (no rank).
/// NCBI TaxId: 2642987
/// </summary>
public abstract class unclassified_Arius : Arius, Iunclassified_Arius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642987;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arius";
}
