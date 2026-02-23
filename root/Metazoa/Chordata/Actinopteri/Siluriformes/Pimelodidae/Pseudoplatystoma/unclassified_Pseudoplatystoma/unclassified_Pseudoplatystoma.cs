using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pseudoplatystoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pseudoplatystoma.unclassified_Pseudoplatystoma;

/// <summary>
/// Abstract class for unclassified Pseudoplatystoma (no rank).
/// NCBI TaxId: 3101902
/// </summary>
public abstract class unclassified_Pseudoplatystoma : Pseudoplatystoma, Iunclassified_Pseudoplatystoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoplatystoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101902;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoplatystoma";
}
