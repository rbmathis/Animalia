using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Facciolella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Facciolella.unclassified_Facciolella;

/// <summary>
/// Abstract class for unclassified Facciolella (no rank).
/// NCBI TaxId: 2726530
/// </summary>
public abstract class unclassified_Facciolella : Facciolella, Iunclassified_Facciolella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Facciolella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726530;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Facciolella";
}
