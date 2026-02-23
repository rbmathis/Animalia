namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Amphisbaena;

/// <summary>
/// Species: Amphisbaena sp. CE1
/// NCBI TaxId: 643091
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphisbaena_sp_CE1 : Amphisbaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphisbaena sp. CE1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphisbaena_sp_CE1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 643091;
}
