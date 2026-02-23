using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Xenisthmidae.Xenisthmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Xenisthmidae.Xenisthmus.unclassified_Xenisthmus;

/// <summary>
/// Abstract class for unclassified Xenisthmus (no rank).
/// NCBI TaxId: 2621696
/// </summary>
public abstract class unclassified_Xenisthmus : Xenisthmus, Iunclassified_Xenisthmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenisthmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621696;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenisthmus";
}
