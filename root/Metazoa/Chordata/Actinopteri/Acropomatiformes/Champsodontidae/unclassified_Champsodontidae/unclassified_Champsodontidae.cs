using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Champsodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Champsodontidae.unclassified_Champsodontidae;

/// <summary>
/// Abstract class for unclassified Champsodontidae (no rank).
/// NCBI TaxId: 1306606
/// </summary>
public abstract class unclassified_Champsodontidae : Champsodontidae, Iunclassified_Champsodontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Champsodontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306606;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Champsodontidae";
}
