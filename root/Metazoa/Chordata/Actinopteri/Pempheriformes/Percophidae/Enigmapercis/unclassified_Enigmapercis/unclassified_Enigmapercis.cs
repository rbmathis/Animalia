using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Enigmapercis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Enigmapercis.unclassified_Enigmapercis;

/// <summary>
/// Abstract class for unclassified Enigmapercis (no rank).
/// NCBI TaxId: 2893523
/// </summary>
public abstract class unclassified_Enigmapercis : Enigmapercis, Iunclassified_Enigmapercis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Enigmapercis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2893523;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Enigmapercis";
}
