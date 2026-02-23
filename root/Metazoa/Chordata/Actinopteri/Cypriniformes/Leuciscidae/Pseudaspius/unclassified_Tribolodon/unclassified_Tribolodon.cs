using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pseudaspius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pseudaspius.unclassified_Tribolodon;

/// <summary>
/// Abstract class for unclassified Tribolodon (no rank).
/// NCBI TaxId: 2649690
/// </summary>
public abstract class unclassified_Tribolodon : Pseudaspius, Iunclassified_Tribolodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tribolodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649690;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tribolodon";
}
