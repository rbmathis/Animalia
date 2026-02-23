using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pimephales;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pimephales.unclassified_Pimephales;

/// <summary>
/// Abstract class for unclassified Pimephales (no rank).
/// NCBI TaxId: 2638217
/// </summary>
public abstract class unclassified_Pimephales : Pimephales, Iunclassified_Pimephales
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pimephales";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638217;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pimephales";
}
