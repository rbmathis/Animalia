using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Namazonurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Namazonurus.unclassified_Namazonurus;

/// <summary>
/// Abstract class for unclassified Namazonurus (no rank).
/// NCBI TaxId: 2631761
/// </summary>
public abstract class unclassified_Namazonurus : Namazonurus, Iunclassified_Namazonurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Namazonurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631761;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Namazonurus";
}
