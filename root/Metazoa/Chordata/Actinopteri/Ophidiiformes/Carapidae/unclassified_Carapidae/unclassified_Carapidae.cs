using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.unclassified_Carapidae;

/// <summary>
/// Abstract class for unclassified Carapidae (no rank).
/// NCBI TaxId: 1781096
/// </summary>
public abstract class unclassified_Carapidae : Carapidae, Iunclassified_Carapidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carapidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1781096;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carapidae";
}
