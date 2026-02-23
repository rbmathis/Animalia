using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Bathyaethiops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Bathyaethiops.unclassified_Bathyaethiops;

/// <summary>
/// Abstract class for unclassified Bathyaethiops (no rank).
/// NCBI TaxId: 2641144
/// </summary>
public abstract class unclassified_Bathyaethiops : Bathyaethiops, Iunclassified_Bathyaethiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathyaethiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641144;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathyaethiops";
}
