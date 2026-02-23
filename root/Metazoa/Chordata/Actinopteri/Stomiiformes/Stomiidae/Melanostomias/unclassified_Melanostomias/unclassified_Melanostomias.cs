using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Melanostomias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Melanostomias.unclassified_Melanostomias;

/// <summary>
/// Abstract class for unclassified Melanostomias (no rank).
/// NCBI TaxId: 2980718
/// </summary>
public abstract class unclassified_Melanostomias : Melanostomias, Iunclassified_Melanostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2980718;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanostomias";
}
