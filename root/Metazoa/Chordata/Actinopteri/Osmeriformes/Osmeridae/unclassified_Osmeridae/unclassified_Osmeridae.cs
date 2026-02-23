using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.unclassified_Osmeridae;

/// <summary>
/// Abstract class for unclassified Osmeridae (no rank).
/// NCBI TaxId: 1442073
/// </summary>
public abstract class unclassified_Osmeridae : Osmeridae, Iunclassified_Osmeridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osmeridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1442073;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osmeridae";
}
