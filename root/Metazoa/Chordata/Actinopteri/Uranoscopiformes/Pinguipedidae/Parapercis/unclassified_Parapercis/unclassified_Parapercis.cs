using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.Parapercis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.Parapercis.unclassified_Parapercis;

/// <summary>
/// Abstract class for unclassified Parapercis (no rank).
/// NCBI TaxId: 2647892
/// </summary>
public abstract class unclassified_Parapercis : Parapercis, Iunclassified_Parapercis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parapercis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647892;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parapercis";
}
