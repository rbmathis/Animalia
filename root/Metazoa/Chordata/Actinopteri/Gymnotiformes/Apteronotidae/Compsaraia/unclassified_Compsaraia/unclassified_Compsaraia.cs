using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Compsaraia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Compsaraia.unclassified_Compsaraia;

/// <summary>
/// Abstract class for unclassified Compsaraia (no rank).
/// NCBI TaxId: 2634530
/// </summary>
public abstract class unclassified_Compsaraia : Compsaraia, Iunclassified_Compsaraia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Compsaraia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634530;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Compsaraia";
}
