namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pelecanoides;

/// <summary>
/// Species: Pelecanoides garnotii
/// NCBI TaxId: 79637
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelecanoides_garnotii : Pelecanoides
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelecanoides garnotii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelecanoides_garnotii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79637;
}
