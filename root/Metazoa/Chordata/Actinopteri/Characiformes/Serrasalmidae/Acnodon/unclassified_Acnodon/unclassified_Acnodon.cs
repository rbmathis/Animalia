using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Acnodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Acnodon.unclassified_Acnodon;

/// <summary>
/// Abstract class for unclassified Acnodon (no rank).
/// NCBI TaxId: 2623241
/// </summary>
public abstract class unclassified_Acnodon : Acnodon, Iunclassified_Acnodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acnodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623241;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acnodon";
}
