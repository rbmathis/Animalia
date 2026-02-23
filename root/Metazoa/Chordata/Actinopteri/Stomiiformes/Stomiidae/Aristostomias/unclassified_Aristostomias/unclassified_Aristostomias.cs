using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Aristostomias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Aristostomias.unclassified_Aristostomias;

/// <summary>
/// Abstract class for unclassified Aristostomias (no rank).
/// NCBI TaxId: 2726569
/// </summary>
public abstract class unclassified_Aristostomias : Aristostomias, Iunclassified_Aristostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aristostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726569;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aristostomias";
}
