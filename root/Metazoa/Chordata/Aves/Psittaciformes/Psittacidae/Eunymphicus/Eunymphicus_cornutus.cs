namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Eunymphicus;

/// <summary>
/// Species: Eunymphicus cornutus
/// NCBI TaxId: 119403
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eunymphicus_cornutus : Eunymphicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eunymphicus cornutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eunymphicus_cornutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 119403;
}
