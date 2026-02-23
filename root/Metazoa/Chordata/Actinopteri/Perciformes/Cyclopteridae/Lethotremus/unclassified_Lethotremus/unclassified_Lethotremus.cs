using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Lethotremus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Lethotremus.unclassified_Lethotremus;

/// <summary>
/// Abstract class for unclassified Lethotremus (no rank).
/// NCBI TaxId: 2644002
/// </summary>
public abstract class unclassified_Lethotremus : Lethotremus, Iunclassified_Lethotremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lethotremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644002;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lethotremus";
}
