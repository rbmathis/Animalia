using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus.Equus_intersubgeneric_hybrids;

/// <summary>
/// Abstract class for Equus intersubgeneric hybrids (no rank).
/// NCBI TaxId: 2715227
/// </summary>
public abstract class Equus_intersubgeneric_hybrids : Equus, IEquus_intersubgeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Equus intersubgeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2715227;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Equus_intersubgeneric_hybrids";
}
