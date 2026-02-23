using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Laubuka;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Laubuka.unclassified_Laubuka;

/// <summary>
/// Abstract class for unclassified Laubuka (no rank).
/// NCBI TaxId: 2715307
/// </summary>
public abstract class unclassified_Laubuka : Laubuka, Iunclassified_Laubuka
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Laubuka";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2715307;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Laubuka";
}
