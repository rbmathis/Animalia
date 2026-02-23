using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Seriola;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Seriola.unclassified_Seriola;

/// <summary>
/// Abstract class for unclassified Seriola (no rank).
/// NCBI TaxId: 3230577
/// </summary>
public abstract class unclassified_Seriola : Seriola, Iunclassified_Seriola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Seriola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3230577;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Seriola";
}
