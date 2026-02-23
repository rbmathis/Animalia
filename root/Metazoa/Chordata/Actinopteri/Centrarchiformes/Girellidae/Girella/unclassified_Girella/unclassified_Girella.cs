using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Girellidae.Girella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Girellidae.Girella.unclassified_Girella;

/// <summary>
/// Abstract class for unclassified Girella (no rank).
/// NCBI TaxId: 2630175
/// </summary>
public abstract class unclassified_Girella : Girella, Iunclassified_Girella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Girella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630175;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Girella";
}
