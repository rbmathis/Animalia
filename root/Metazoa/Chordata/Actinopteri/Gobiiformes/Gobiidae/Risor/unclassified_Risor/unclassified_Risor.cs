using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Risor;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Risor.unclassified_Risor;

/// <summary>
/// Abstract class for unclassified Risor (no rank).
/// NCBI TaxId: 2644691
/// </summary>
public abstract class unclassified_Risor : Risor, Iunclassified_Risor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Risor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644691;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Risor";
}
