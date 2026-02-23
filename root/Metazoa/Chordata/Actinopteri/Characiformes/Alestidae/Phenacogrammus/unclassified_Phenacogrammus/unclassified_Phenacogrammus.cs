using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Phenacogrammus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Phenacogrammus.unclassified_Phenacogrammus;

/// <summary>
/// Abstract class for unclassified Phenacogrammus (no rank).
/// NCBI TaxId: 2677732
/// </summary>
public abstract class unclassified_Phenacogrammus : Phenacogrammus, Iunclassified_Phenacogrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phenacogrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677732;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phenacogrammus";
}
