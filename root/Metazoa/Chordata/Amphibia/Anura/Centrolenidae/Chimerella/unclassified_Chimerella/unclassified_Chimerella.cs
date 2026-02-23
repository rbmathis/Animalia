using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Chimerella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Chimerella.unclassified_Chimerella;

/// <summary>
/// Abstract class for unclassified Chimerella (no rank).
/// NCBI TaxId: 2649849
/// </summary>
public abstract class unclassified_Chimerella : Chimerella, Iunclassified_Chimerella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chimerella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649849;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chimerella";
}
