namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Colinus;

/// <summary>
/// Species: Colinus virginianus
/// NCBI TaxId: 9014
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colinus_virginianus : Colinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colinus virginianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colinus_virginianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9014;
}
