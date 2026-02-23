using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Caiman;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Caiman.unclassified_Caiman;

/// <summary>
/// Abstract class for unclassified Caiman (no rank).
/// NCBI TaxId: 2622682
/// </summary>
public abstract class unclassified_Caiman : Caiman, Iunclassified_Caiman
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caiman";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622682;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caiman";
}
