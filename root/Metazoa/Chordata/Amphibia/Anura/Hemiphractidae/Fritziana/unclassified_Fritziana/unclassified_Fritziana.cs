using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Fritziana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Fritziana.unclassified_Fritziana;

/// <summary>
/// Abstract class for unclassified Fritziana (no rank).
/// NCBI TaxId: 2643598
/// </summary>
public abstract class unclassified_Fritziana : Fritziana, Iunclassified_Fritziana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fritziana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643598;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fritziana";
}
