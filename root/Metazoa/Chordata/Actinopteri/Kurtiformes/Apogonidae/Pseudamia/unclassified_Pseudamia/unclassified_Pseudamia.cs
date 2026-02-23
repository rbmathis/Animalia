using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pseudamia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pseudamia.unclassified_Pseudamia;

/// <summary>
/// Abstract class for unclassified Pseudamia (no rank).
/// NCBI TaxId: 2648206
/// </summary>
public abstract class unclassified_Pseudamia : Pseudamia, Iunclassified_Pseudamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648206;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudamia";
}
