using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Suezichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Suezichthys.unclassified_Suezichthys;

/// <summary>
/// Abstract class for unclassified Suezichthys (no rank).
/// NCBI TaxId: 2630228
/// </summary>
public abstract class unclassified_Suezichthys : Suezichthys, Iunclassified_Suezichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Suezichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630228;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Suezichthys";
}
