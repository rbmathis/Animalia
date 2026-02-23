using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oplopomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oplopomus.unclassified_Oplopomus;

/// <summary>
/// Abstract class for unclassified Oplopomus (no rank).
/// NCBI TaxId: 2989924
/// </summary>
public abstract class unclassified_Oplopomus : Oplopomus, Iunclassified_Oplopomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oplopomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2989924;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oplopomus";
}
