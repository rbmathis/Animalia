using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Glauconycteris;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Glauconycteris.unclassified_Glauconycteris;

/// <summary>
/// Abstract class for unclassified Glauconycteris (no rank).
/// NCBI TaxId: 2634626
/// </summary>
public abstract class unclassified_Glauconycteris : Glauconycteris, Iunclassified_Glauconycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glauconycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634626;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glauconycteris";
}
