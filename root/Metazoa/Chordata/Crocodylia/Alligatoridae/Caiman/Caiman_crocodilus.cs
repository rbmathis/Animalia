namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Caiman;

/// <summary>
/// Species: Caiman crocodilus
/// NCBI TaxId: 8499
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Caiman_crocodilus : Caiman
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Caiman crocodilus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Caiman_crocodilus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8499;
}
