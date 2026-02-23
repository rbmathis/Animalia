namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Egretta;

/// <summary>
/// Species: Egretta rufescens
/// NCBI TaxId: 56074
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Egretta_rufescens : Egretta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Egretta rufescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Egretta_rufescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56074;
}
