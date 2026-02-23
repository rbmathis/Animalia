using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Ardeola;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Ardeola.unclassified_Ardeola;

/// <summary>
/// Abstract class for unclassified Ardeola (no rank).
/// NCBI TaxId: 2628092
/// </summary>
public abstract class unclassified_Ardeola : Ardeola, Iunclassified_Ardeola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ardeola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628092;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ardeola";
}
