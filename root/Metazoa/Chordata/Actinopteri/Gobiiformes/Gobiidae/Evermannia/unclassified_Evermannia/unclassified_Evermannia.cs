using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Evermannia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Evermannia.unclassified_Evermannia;

/// <summary>
/// Abstract class for unclassified Evermannia (no rank).
/// NCBI TaxId: 2642340
/// </summary>
public abstract class unclassified_Evermannia : Evermannia, Iunclassified_Evermannia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Evermannia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642340;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Evermannia";
}
