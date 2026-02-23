using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Photostomias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Photostomias.unclassified_Photostomias;

/// <summary>
/// Abstract class for unclassified Photostomias (no rank).
/// NCBI TaxId: 2618696
/// </summary>
public abstract class unclassified_Photostomias : Photostomias, Iunclassified_Photostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Photostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618696;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Photostomias";
}
