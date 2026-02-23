namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Alectoris;

/// <summary>
/// Species: Alectoris melanocephala
/// NCBI TaxId: 40180
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alectoris_melanocephala : Alectoris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alectoris melanocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alectoris_melanocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 40180;
}
