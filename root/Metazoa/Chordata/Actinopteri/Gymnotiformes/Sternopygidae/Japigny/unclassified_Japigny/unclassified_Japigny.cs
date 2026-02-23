using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Japigny;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Japigny.unclassified_Japigny;

/// <summary>
/// Abstract class for unclassified Japigny (no rank).
/// NCBI TaxId: 3101863
/// </summary>
public abstract class unclassified_Japigny : Japigny, Iunclassified_Japigny
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Japigny";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101863;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Japigny";
}
