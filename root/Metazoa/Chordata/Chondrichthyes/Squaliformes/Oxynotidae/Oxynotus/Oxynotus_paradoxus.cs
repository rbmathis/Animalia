namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Oxynotidae.Oxynotus;

/// <summary>
/// Species: Oxynotus paradoxus
/// NCBI TaxId: 862900
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oxynotus_paradoxus : Oxynotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oxynotus paradoxus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oxynotus_paradoxus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 862900;
}
