namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Aerodramus;

/// <summary>
/// Species: Aerodramus sp.
/// NCBI TaxId: 2336749
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aerodramus_sp : Aerodramus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aerodramus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aerodramus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2336749;
}
