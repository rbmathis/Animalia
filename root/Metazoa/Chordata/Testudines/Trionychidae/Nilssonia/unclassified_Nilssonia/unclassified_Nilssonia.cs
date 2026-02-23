using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Nilssonia;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Nilssonia.unclassified_Nilssonia;

/// <summary>
/// Abstract class for unclassified Nilssonia (no rank).
/// NCBI TaxId: 2641145
/// </summary>
public abstract class unclassified_Nilssonia : Nilssonia, Iunclassified_Nilssonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nilssonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641145;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nilssonia";
}
