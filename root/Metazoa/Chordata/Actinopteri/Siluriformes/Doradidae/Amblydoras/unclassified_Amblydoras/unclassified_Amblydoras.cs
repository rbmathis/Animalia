using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Amblydoras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Amblydoras.unclassified_Amblydoras;

/// <summary>
/// Abstract class for unclassified Amblydoras (no rank).
/// NCBI TaxId: 2638051
/// </summary>
public abstract class unclassified_Amblydoras : Amblydoras, Iunclassified_Amblydoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amblydoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638051;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amblydoras";
}
