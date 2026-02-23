using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Callechelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Callechelys.unclassified_Callechelys;

/// <summary>
/// Abstract class for unclassified Callechelys (no rank).
/// NCBI TaxId: 2638313
/// </summary>
public abstract class unclassified_Callechelys : Callechelys, Iunclassified_Callechelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callechelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638313;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callechelys";
}
