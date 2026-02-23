using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Xyrias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Xyrias.unclassified_Xyrias;

/// <summary>
/// Abstract class for unclassified Xyrias (no rank).
/// NCBI TaxId: 2719383
/// </summary>
public abstract class unclassified_Xyrias : Xyrias, Iunclassified_Xyrias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xyrias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2719383;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xyrias";
}
