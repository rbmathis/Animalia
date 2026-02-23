using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Osteolaemus;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Osteolaemus.unclassified_Osteolaemus;

/// <summary>
/// Abstract class for unclassified Osteolaemus (no rank).
/// NCBI TaxId: 1295540
/// </summary>
public abstract class unclassified_Osteolaemus : Osteolaemus, Iunclassified_Osteolaemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osteolaemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1295540;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osteolaemus";
}
