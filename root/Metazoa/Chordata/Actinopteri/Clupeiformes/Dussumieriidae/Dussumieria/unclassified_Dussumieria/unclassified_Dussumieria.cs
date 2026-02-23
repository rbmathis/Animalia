using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Dussumieriidae.Dussumieria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Dussumieriidae.Dussumieria.unclassified_Dussumieria;

/// <summary>
/// Abstract class for unclassified Dussumieria (no rank).
/// NCBI TaxId: 2644953
/// </summary>
public abstract class unclassified_Dussumieria : Dussumieria, Iunclassified_Dussumieria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dussumieria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644953;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dussumieria";
}
