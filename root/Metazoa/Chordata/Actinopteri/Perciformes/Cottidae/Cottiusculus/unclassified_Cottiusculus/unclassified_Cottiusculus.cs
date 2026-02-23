using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottiusculus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottiusculus.unclassified_Cottiusculus;

/// <summary>
/// Abstract class for unclassified Cottiusculus (no rank).
/// NCBI TaxId: 2648750
/// </summary>
public abstract class unclassified_Cottiusculus : Cottiusculus, Iunclassified_Cottiusculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cottiusculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648750;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cottiusculus";
}
