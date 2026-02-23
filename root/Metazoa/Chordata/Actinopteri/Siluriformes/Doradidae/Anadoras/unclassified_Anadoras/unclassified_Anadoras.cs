using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Anadoras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Anadoras.unclassified_Anadoras;

/// <summary>
/// Abstract class for unclassified Anadoras (no rank).
/// NCBI TaxId: 2641407
/// </summary>
public abstract class unclassified_Anadoras : Anadoras, Iunclassified_Anadoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anadoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641407;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anadoras";
}
