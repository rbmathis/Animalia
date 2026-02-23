namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Amphisbaena;

/// <summary>
/// Species: Amphisbaena vermicularis
/// NCBI TaxId: 643088
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphisbaena_vermicularis : Amphisbaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphisbaena vermicularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphisbaena_vermicularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 643088;
}
