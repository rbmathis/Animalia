using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Hemibrycon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Hemibrycon.unclassified_Hemibrycon;

/// <summary>
/// Abstract class for unclassified Hemibrycon (no rank).
/// NCBI TaxId: 2685305
/// </summary>
public abstract class unclassified_Hemibrycon : Hemibrycon, Iunclassified_Hemibrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemibrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685305;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemibrycon";
}
