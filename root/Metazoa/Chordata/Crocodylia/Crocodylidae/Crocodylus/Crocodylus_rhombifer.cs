namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Crocodylus;

/// <summary>
/// Species: Crocodylus rhombifer
/// NCBI TaxId: 184239
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocodylus_rhombifer : Crocodylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocodylus rhombifer";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocodylus_rhombifer";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 184239;
}
