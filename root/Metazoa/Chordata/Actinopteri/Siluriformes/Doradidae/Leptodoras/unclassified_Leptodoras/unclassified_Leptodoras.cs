using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Leptodoras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Leptodoras.unclassified_Leptodoras;

/// <summary>
/// Abstract class for unclassified Leptodoras (no rank).
/// NCBI TaxId: 2621854
/// </summary>
public abstract class unclassified_Leptodoras : Leptodoras, Iunclassified_Leptodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621854;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptodoras";
}
