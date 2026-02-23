namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Amphisbaena;

/// <summary>
/// Species: Amphisbaena ignatiana
/// NCBI TaxId: 643086
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphisbaena_ignatiana : Amphisbaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphisbaena ignatiana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphisbaena_ignatiana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 643086;
}
