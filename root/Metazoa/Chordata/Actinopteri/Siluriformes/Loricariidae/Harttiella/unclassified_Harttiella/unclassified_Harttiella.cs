using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Harttiella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Harttiella.unclassified_Harttiella;

/// <summary>
/// Abstract class for unclassified Harttiella (no rank).
/// NCBI TaxId: 3143505
/// </summary>
public abstract class unclassified_Harttiella : Harttiella, Iunclassified_Harttiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Harttiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3143505;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Harttiella";
}
