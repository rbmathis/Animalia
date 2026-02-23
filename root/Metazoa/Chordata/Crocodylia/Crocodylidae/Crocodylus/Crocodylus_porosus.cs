namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Crocodylus;

/// <summary>
/// Species: Crocodylus porosus
/// NCBI TaxId: 8502
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocodylus_porosus : Crocodylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocodylus porosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocodylus_porosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8502;
}
