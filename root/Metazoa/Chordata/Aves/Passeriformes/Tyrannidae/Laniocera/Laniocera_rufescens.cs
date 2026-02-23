namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Laniocera;

/// <summary>
/// Species: Laniocera rufescens
/// NCBI TaxId: 2767945
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Laniocera_rufescens : Laniocera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Laniocera rufescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Laniocera_rufescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2767945;
}
