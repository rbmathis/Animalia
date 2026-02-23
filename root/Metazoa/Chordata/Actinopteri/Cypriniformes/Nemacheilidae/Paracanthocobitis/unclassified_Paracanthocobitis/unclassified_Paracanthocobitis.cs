using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Paracanthocobitis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Paracanthocobitis.unclassified_Paracanthocobitis;

/// <summary>
/// Abstract class for unclassified Paracanthocobitis (no rank).
/// NCBI TaxId: 2626320
/// </summary>
public abstract class unclassified_Paracanthocobitis : Paracanthocobitis, Iunclassified_Paracanthocobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paracanthocobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626320;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paracanthocobitis";
}
