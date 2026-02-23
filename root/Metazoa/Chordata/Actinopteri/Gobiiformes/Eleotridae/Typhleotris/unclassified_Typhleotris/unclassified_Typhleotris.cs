using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Typhleotris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Typhleotris.unclassified_Typhleotris;

/// <summary>
/// Abstract class for unclassified Typhleotris (no rank).
/// NCBI TaxId: 2618170
/// </summary>
public abstract class unclassified_Typhleotris : Typhleotris, Iunclassified_Typhleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Typhleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618170;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Typhleotris";
}
