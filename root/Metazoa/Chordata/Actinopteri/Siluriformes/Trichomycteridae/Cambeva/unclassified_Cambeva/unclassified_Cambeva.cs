using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Cambeva;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Cambeva.unclassified_Cambeva;

/// <summary>
/// Abstract class for unclassified Cambeva (no rank).
/// NCBI TaxId: 2617891
/// </summary>
public abstract class unclassified_Cambeva : Cambeva, Iunclassified_Cambeva
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cambeva";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617891;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cambeva";
}
