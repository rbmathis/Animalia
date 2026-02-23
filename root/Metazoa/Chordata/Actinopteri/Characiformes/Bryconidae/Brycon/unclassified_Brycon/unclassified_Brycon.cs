using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Brycon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Brycon.unclassified_Brycon;

/// <summary>
/// Abstract class for unclassified Brycon (no rank).
/// NCBI TaxId: 2644752
/// </summary>
public abstract class unclassified_Brycon : Brycon, Iunclassified_Brycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644752;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brycon";
}
