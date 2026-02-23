using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Doras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Doras.unclassified_Doras;

/// <summary>
/// Abstract class for unclassified Doras (no rank).
/// NCBI TaxId: 3101842
/// </summary>
public abstract class unclassified_Doras : Doras, Iunclassified_Doras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Doras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101842;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Doras";
}
