using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.unclassified_Thunnini;

/// <summary>
/// Abstract class for unclassified Thunnini (no rank).
/// NCBI TaxId: 2966646
/// </summary>
public abstract class unclassified_Thunnini : Scombridae, Iunclassified_Thunnini
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thunnini";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2966646;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thunnini";
}
