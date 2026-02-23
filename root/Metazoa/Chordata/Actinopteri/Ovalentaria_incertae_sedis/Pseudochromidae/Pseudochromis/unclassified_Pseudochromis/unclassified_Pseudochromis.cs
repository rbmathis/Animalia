using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Pseudochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Pseudochromis.unclassified_Pseudochromis;

/// <summary>
/// Abstract class for unclassified Pseudochromis (no rank).
/// NCBI TaxId: 2641628
/// </summary>
public abstract class unclassified_Pseudochromis : Pseudochromis, Iunclassified_Pseudochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641628;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudochromis";
}
