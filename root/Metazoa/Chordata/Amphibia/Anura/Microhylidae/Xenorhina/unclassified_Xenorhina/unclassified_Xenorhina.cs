using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Xenorhina;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Xenorhina.unclassified_Xenorhina;

/// <summary>
/// Abstract class for unclassified Xenorhina (no rank).
/// NCBI TaxId: 2685427
/// </summary>
public abstract class unclassified_Xenorhina : Xenorhina, Iunclassified_Xenorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685427;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenorhina";
}
