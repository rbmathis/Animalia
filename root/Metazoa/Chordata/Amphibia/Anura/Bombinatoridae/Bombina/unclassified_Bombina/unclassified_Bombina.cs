using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae.Bombina;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae.Bombina.unclassified_Bombina;

/// <summary>
/// Abstract class for unclassified Bombina (no rank).
/// NCBI TaxId: 2639055
/// </summary>
public abstract class unclassified_Bombina : Bombina, Iunclassified_Bombina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bombina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639055;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bombina";
}
