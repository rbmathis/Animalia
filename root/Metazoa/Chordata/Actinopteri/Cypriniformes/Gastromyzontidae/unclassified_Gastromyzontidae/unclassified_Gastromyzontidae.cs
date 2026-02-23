using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.unclassified_Gastromyzontidae;

/// <summary>
/// Abstract class for unclassified Gastromyzontidae (no rank).
/// NCBI TaxId: 3085682
/// </summary>
public abstract class unclassified_Gastromyzontidae : Gastromyzontidae, Iunclassified_Gastromyzontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gastromyzontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3085682;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gastromyzontidae";
}
