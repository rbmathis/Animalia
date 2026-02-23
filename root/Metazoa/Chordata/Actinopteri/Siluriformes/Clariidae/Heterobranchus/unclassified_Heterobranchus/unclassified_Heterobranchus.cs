using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Heterobranchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Heterobranchus.unclassified_Heterobranchus;

/// <summary>
/// Abstract class for unclassified Heterobranchus (no rank).
/// NCBI TaxId: 2685038
/// </summary>
public abstract class unclassified_Heterobranchus : Heterobranchus, Iunclassified_Heterobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heterobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685038;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heterobranchus";
}
