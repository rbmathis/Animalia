using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Characidae_incertae_sedis.Schultzites;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Characidae_incertae_sedis.Schultzites.unclassified_Schultzites;

/// <summary>
/// Abstract class for unclassified Schultzites (no rank).
/// NCBI TaxId: 2637071
/// </summary>
public abstract class unclassified_Schultzites : Schultzites, Iunclassified_Schultzites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schultzites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637071;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schultzites";
}
