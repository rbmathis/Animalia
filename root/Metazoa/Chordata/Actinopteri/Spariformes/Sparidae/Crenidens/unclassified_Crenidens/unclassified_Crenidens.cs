using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Crenidens;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Crenidens.unclassified_Crenidens;

/// <summary>
/// Abstract class for unclassified Crenidens (no rank).
/// NCBI TaxId: 3027002
/// </summary>
public abstract class unclassified_Crenidens : Crenidens, Iunclassified_Crenidens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crenidens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3027002;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crenidens";
}
