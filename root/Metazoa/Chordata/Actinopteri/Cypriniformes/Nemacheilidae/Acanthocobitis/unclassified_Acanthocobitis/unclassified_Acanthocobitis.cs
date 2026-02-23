using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Acanthocobitis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Acanthocobitis.unclassified_Acanthocobitis;

/// <summary>
/// Abstract class for unclassified Acanthocobitis (no rank).
/// NCBI TaxId: 2618831
/// </summary>
public abstract class unclassified_Acanthocobitis : Acanthocobitis, Iunclassified_Acanthocobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthocobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618831;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthocobitis";
}
