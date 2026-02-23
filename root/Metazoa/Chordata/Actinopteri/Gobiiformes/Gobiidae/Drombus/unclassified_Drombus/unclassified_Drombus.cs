using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Drombus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Drombus.unclassified_Drombus;

/// <summary>
/// Abstract class for unclassified Drombus (no rank).
/// NCBI TaxId: 2631686
/// </summary>
public abstract class unclassified_Drombus : Drombus, Iunclassified_Drombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Drombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631686;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Drombus";
}
