using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Nebris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Nebris.unclassified_Nebris;

/// <summary>
/// Abstract class for unclassified Nebris (no rank).
/// NCBI TaxId: 2806149
/// </summary>
public abstract class unclassified_Nebris : Nebris, Iunclassified_Nebris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nebris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2806149;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nebris";
}
