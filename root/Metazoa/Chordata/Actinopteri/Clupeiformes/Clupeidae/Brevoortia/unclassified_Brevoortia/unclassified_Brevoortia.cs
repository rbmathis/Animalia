using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Brevoortia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Brevoortia.unclassified_Brevoortia;

/// <summary>
/// Abstract class for unclassified Brevoortia (no rank).
/// NCBI TaxId: 2685410
/// </summary>
public abstract class unclassified_Brevoortia : Brevoortia, Iunclassified_Brevoortia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brevoortia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685410;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brevoortia";
}
