namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Pyrrhula;

/// <summary>
/// Species: Pyrrhula erythrocephala
/// NCBI TaxId: 552620
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyrrhula_erythrocephala : Pyrrhula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyrrhula erythrocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyrrhula_erythrocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 552620;
}
