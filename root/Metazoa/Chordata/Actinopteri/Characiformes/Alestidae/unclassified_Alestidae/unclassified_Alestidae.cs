using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.unclassified_Alestidae;

/// <summary>
/// Abstract class for unclassified Alestidae (no rank).
/// NCBI TaxId: 3478425
/// </summary>
public abstract class unclassified_Alestidae : Alestidae, Iunclassified_Alestidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alestidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3478425;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alestidae";
}
