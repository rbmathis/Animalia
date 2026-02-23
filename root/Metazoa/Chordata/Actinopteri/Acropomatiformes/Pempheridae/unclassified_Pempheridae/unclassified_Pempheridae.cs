using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae.unclassified_Pempheridae;

/// <summary>
/// Abstract class for unclassified Pempheridae (no rank).
/// NCBI TaxId: 2581984
/// </summary>
public abstract class unclassified_Pempheridae : Pempheridae, Iunclassified_Pempheridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pempheridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2581984;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pempheridae";
}
