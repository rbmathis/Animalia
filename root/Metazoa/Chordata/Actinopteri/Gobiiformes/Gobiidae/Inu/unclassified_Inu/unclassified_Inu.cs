using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Inu;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Inu.unclassified_Inu;

/// <summary>
/// Abstract class for unclassified Inu (no rank).
/// NCBI TaxId: 3043672
/// </summary>
public abstract class unclassified_Inu : Inu, Iunclassified_Inu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Inu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3043672;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Inu";
}
