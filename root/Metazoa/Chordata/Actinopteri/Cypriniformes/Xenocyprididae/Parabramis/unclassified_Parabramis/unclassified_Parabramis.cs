using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Parabramis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Parabramis.unclassified_Parabramis;

/// <summary>
/// Abstract class for unclassified Parabramis (no rank).
/// NCBI TaxId: 2647054
/// </summary>
public abstract class unclassified_Parabramis : Parabramis, Iunclassified_Parabramis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parabramis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647054;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parabramis";
}
