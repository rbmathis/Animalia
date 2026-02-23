namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Patagioenas;

/// <summary>
/// Species: Patagioenas leucocephala
/// NCBI TaxId: 372311
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Patagioenas_leucocephala : Patagioenas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Patagioenas leucocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Patagioenas_leucocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 372311;
}
