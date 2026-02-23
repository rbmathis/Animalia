using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae.Glossanodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae.Glossanodon.unclassified_Glossanodon;

/// <summary>
/// Abstract class for unclassified Glossanodon (no rank).
/// NCBI TaxId: 2636991
/// </summary>
public abstract class unclassified_Glossanodon : Glossanodon, Iunclassified_Glossanodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glossanodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636991;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glossanodon";
}
