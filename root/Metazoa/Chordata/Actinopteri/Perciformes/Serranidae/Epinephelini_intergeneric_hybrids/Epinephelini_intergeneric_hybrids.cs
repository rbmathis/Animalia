using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Epinephelini_intergeneric_hybrids;

/// <summary>
/// Abstract class for Epinephelini intergeneric hybrids (no rank).
/// NCBI TaxId: 2588633
/// </summary>
public abstract class Epinephelini_intergeneric_hybrids : Serranidae, IEpinephelini_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epinephelini intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2588633;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Epinephelini_intergeneric_hybrids";
}
