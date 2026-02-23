namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Testudo;

/// <summary>
/// Species: Testudo horsfieldii
/// NCBI TaxId: 101699
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Testudo_horsfieldii : Testudo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Testudo horsfieldii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Testudo_horsfieldii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 101699;
}
