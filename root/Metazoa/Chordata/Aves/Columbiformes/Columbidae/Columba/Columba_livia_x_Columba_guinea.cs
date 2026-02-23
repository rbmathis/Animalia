namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Columba;

/// <summary>
/// Species: Columba livia x Columba guinea
/// NCBI TaxId: 3068351
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Columba_livia_x_Columba_guinea : Columba
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Columba livia x Columba guinea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Columba_livia_x_Columba_guinea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3068351;
}
