namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phyllotis;

/// <summary>
/// Species: Phyllotis stenops
/// NCBI TaxId: 2014509
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllotis_stenops : Phyllotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllotis stenops";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllotis_stenops";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2014509;
}
