namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Ammodramus;

/// <summary>
/// Species: Ammodramus savannarum
/// NCBI TaxId: 135422
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ammodramus_savannarum : Ammodramus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ammodramus savannarum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ammodramus_savannarum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 135422;
}
