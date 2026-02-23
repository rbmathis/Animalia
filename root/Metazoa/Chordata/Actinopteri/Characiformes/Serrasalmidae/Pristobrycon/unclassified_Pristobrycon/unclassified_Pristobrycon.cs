using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Pristobrycon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Pristobrycon.unclassified_Pristobrycon;

/// <summary>
/// Abstract class for unclassified Pristobrycon (no rank).
/// NCBI TaxId: 2617775
/// </summary>
public abstract class unclassified_Pristobrycon : Pristobrycon, Iunclassified_Pristobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617775;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristobrycon";
}
