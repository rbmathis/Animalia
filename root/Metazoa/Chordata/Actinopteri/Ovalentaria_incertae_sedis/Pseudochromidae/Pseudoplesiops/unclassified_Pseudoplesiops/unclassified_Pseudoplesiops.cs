using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Pseudoplesiops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Pseudoplesiops.unclassified_Pseudoplesiops;

/// <summary>
/// Abstract class for unclassified Pseudoplesiops (no rank).
/// NCBI TaxId: 2677817
/// </summary>
public abstract class unclassified_Pseudoplesiops : Pseudoplesiops, Iunclassified_Pseudoplesiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoplesiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677817;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoplesiops";
}
