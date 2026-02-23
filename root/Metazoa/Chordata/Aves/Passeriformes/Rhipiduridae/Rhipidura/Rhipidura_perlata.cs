namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae.Rhipidura;

/// <summary>
/// Species: Rhipidura perlata
/// NCBI TaxId: 632606
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhipidura_perlata : Rhipidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhipidura perlata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhipidura_perlata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 632606;
}
