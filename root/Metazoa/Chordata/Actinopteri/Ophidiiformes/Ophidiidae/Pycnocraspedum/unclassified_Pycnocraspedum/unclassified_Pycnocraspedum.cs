using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Pycnocraspedum;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Pycnocraspedum.unclassified_Pycnocraspedum;

/// <summary>
/// Abstract class for unclassified Pycnocraspedum (no rank).
/// NCBI TaxId: 3095279
/// </summary>
public abstract class unclassified_Pycnocraspedum : Pycnocraspedum, Iunclassified_Pycnocraspedum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pycnocraspedum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3095279;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pycnocraspedum";
}
