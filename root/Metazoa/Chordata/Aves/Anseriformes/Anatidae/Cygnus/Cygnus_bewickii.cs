namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cygnus;

/// <summary>
/// Species: Cygnus bewickii
/// NCBI TaxId: 541010
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cygnus_bewickii : Cygnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cygnus bewickii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cygnus_bewickii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 541010;
}
