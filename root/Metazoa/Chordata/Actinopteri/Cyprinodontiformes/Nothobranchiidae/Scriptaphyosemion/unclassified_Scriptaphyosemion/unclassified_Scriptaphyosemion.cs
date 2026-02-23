using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Scriptaphyosemion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Scriptaphyosemion.unclassified_Scriptaphyosemion;

/// <summary>
/// Abstract class for unclassified Scriptaphyosemion (no rank).
/// NCBI TaxId: 2630323
/// </summary>
public abstract class unclassified_Scriptaphyosemion : Scriptaphyosemion, Iunclassified_Scriptaphyosemion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scriptaphyosemion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630323;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scriptaphyosemion";
}
