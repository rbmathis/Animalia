using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Plesiops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Plesiops.unclassified_Plesiops;

/// <summary>
/// Abstract class for unclassified Plesiops (no rank).
/// NCBI TaxId: 2625191
/// </summary>
public abstract class unclassified_Plesiops : Plesiops, Iunclassified_Plesiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plesiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625191;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plesiops";
}
