using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Scythrophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Scythrophrys.unclassified_Scythrophrys;

/// <summary>
/// Abstract class for unclassified Scythrophrys (no rank).
/// NCBI TaxId: 2647043
/// </summary>
public abstract class unclassified_Scythrophrys : Scythrophrys, Iunclassified_Scythrophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scythrophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647043;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scythrophrys";
}
