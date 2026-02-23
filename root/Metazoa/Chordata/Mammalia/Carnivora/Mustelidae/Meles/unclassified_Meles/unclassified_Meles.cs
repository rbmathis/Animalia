using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Meles;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Meles.unclassified_Meles;

/// <summary>
/// Abstract class for unclassified Meles (no rank).
/// NCBI TaxId: 2647378
/// </summary>
public abstract class unclassified_Meles : Meles, Iunclassified_Meles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Meles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647378;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Meles";
}
