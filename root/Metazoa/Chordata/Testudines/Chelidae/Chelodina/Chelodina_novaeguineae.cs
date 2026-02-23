namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina novaeguineae
/// NCBI TaxId: 200900
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_novaeguineae : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina novaeguineae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_novaeguineae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 200900;
}
