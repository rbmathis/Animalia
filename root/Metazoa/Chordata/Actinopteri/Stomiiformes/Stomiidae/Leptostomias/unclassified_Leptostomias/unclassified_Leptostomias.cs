using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Leptostomias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Leptostomias.unclassified_Leptostomias;

/// <summary>
/// Abstract class for unclassified Leptostomias (no rank).
/// NCBI TaxId: 2649217
/// </summary>
public abstract class unclassified_Leptostomias : Leptostomias, Iunclassified_Leptostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649217;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptostomias";
}
