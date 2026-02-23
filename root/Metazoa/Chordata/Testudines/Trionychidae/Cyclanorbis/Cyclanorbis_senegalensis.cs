namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Cyclanorbis;

/// <summary>
/// Species: Cyclanorbis senegalensis
/// NCBI TaxId: 227468
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyclanorbis_senegalensis : Cyclanorbis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyclanorbis senegalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyclanorbis_senegalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 227468;
}
