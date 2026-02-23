using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae.unclassified_Serrivomeridae;

/// <summary>
/// Abstract class for unclassified Serrivomeridae (no rank).
/// NCBI TaxId: 138908
/// </summary>
public abstract class unclassified_Serrivomeridae : Serrivomeridae, Iunclassified_Serrivomeridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serrivomeridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 138908;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serrivomeridae";
}
