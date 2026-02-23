using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Aristelliger;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Aristelliger.unclassified_Aristelliger;

/// <summary>
/// Abstract class for unclassified Aristelliger (no rank).
/// NCBI TaxId: 2685401
/// </summary>
public abstract class unclassified_Aristelliger : Aristelliger, Iunclassified_Aristelliger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aristelliger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685401;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aristelliger";
}
