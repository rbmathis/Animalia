namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Desmodus;

/// <summary>
/// Species: Desmodus rotundus
/// NCBI TaxId: 9430
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Desmodus_rotundus : Desmodus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Desmodus rotundus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Desmodus_rotundus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9430;
}
