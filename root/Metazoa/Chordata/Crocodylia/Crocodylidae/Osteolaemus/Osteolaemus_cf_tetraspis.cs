namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Osteolaemus;

/// <summary>
/// Species: Osteolaemus cf. tetraspis
/// NCBI TaxId: 2784190
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteolaemus_cf_tetraspis : Osteolaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteolaemus cf. tetraspis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteolaemus_cf_tetraspis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2784190;
}
