namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Etmopterus;

/// <summary>
/// Species: Etmopterus spinax
/// NCBI TaxId: 648166
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Etmopterus_spinax : Etmopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Etmopterus spinax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Etmopterus_spinax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 648166;
}
