using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Emydura;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Emydura.unclassified_Emydura;

/// <summary>
/// Abstract class for unclassified Emydura (no rank).
/// NCBI TaxId: 2636607
/// </summary>
public abstract class unclassified_Emydura : Emydura, Iunclassified_Emydura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Emydura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636607;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Emydura";
}
