using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pseudolais;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pseudolais.unclassified_Pseudolais;

/// <summary>
/// Abstract class for unclassified Pseudolais (no rank).
/// NCBI TaxId: 3425896
/// </summary>
public abstract class unclassified_Pseudolais : Pseudolais, Iunclassified_Pseudolais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudolais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3425896;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudolais";
}
