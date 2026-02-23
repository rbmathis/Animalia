using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Dicrolene;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Dicrolene.unclassified_Dicrolene;

/// <summary>
/// Abstract class for unclassified Dicrolene (no rank).
/// NCBI TaxId: 3095275
/// </summary>
public abstract class unclassified_Dicrolene : Dicrolene, Iunclassified_Dicrolene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dicrolene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3095275;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dicrolene";
}
