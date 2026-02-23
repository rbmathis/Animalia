using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Bagrichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Bagrichthys.unclassified_Bagrichthys;

/// <summary>
/// Abstract class for unclassified Bagrichthys (no rank).
/// NCBI TaxId: 2633898
/// </summary>
public abstract class unclassified_Bagrichthys : Bagrichthys, Iunclassified_Bagrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bagrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633898;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bagrichthys";
}
