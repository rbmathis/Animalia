using AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Cheloniidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Cheloniidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2527869
/// </summary>
public abstract class Cheloniidae_intergeneric_hybrids : Cheloniidae, ICheloniidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheloniidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2527869;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Cheloniidae_intergeneric_hybrids";
}
