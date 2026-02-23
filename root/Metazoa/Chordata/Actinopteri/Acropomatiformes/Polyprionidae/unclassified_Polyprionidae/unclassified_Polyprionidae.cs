using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Polyprionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Polyprionidae.unclassified_Polyprionidae;

/// <summary>
/// Abstract class for unclassified Polyprionidae (no rank).
/// NCBI TaxId: 2613819
/// </summary>
public abstract class unclassified_Polyprionidae : Polyprionidae, Iunclassified_Polyprionidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polyprionidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613819;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polyprionidae";
}
