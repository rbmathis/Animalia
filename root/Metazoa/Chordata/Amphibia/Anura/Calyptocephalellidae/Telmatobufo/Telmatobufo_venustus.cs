namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Calyptocephalellidae.Telmatobufo;

/// <summary>
/// Species: Telmatobufo venustus
/// NCBI TaxId: 107247
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Telmatobufo_venustus : Telmatobufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Telmatobufo venustus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Telmatobufo_venustus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 107247;
}
