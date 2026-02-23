using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax.unclassified_Scinax;

/// <summary>
/// Abstract class for unclassified Scinax (no rank).
/// NCBI TaxId: 2622335
/// </summary>
public abstract class unclassified_Scinax : Scinax, Iunclassified_Scinax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scinax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622335;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scinax";
}
