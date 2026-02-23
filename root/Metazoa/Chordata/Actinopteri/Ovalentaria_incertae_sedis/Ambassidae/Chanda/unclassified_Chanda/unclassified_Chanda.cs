using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Chanda;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Chanda.unclassified_Chanda;

/// <summary>
/// Abstract class for unclassified Chanda (no rank).
/// NCBI TaxId: 2649168
/// </summary>
public abstract class unclassified_Chanda : Chanda, Iunclassified_Chanda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chanda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649168;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chanda";
}
