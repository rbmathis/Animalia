using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Gadella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Gadella.unclassified_Gadella;

/// <summary>
/// Abstract class for unclassified Gadella (no rank).
/// NCBI TaxId: 2726532
/// </summary>
public abstract class unclassified_Gadella : Gadella, Iunclassified_Gadella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gadella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726532;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gadella";
}
