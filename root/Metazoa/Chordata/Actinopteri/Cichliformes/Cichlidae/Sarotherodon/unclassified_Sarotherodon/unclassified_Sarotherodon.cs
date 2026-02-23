using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sarotherodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sarotherodon.unclassified_Sarotherodon;

/// <summary>
/// Abstract class for unclassified Sarotherodon (no rank).
/// NCBI TaxId: 2635925
/// </summary>
public abstract class unclassified_Sarotherodon : Sarotherodon, Iunclassified_Sarotherodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sarotherodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635925;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sarotherodon";
}
