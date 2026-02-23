using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Diplodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Diplodus.unclassified_Diplodus;

/// <summary>
/// Abstract class for unclassified Diplodus (no rank).
/// NCBI TaxId: 2631579
/// </summary>
public abstract class unclassified_Diplodus : Diplodus, Iunclassified_Diplodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diplodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631579;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diplodus";
}
