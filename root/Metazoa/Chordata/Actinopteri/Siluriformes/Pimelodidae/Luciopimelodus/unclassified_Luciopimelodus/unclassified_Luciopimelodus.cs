using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Luciopimelodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Luciopimelodus.unclassified_Luciopimelodus;

/// <summary>
/// Abstract class for unclassified Luciopimelodus (no rank).
/// NCBI TaxId: 2636858
/// </summary>
public abstract class unclassified_Luciopimelodus : Luciopimelodus, Iunclassified_Luciopimelodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Luciopimelodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636858;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Luciopimelodus";
}
