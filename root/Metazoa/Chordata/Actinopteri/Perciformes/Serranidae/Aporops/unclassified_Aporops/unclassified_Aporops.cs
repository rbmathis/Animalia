using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Aporops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Aporops.unclassified_Aporops;

/// <summary>
/// Abstract class for unclassified Aporops (no rank).
/// NCBI TaxId: 2621555
/// </summary>
public abstract class unclassified_Aporops : Aporops, Iunclassified_Aporops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aporops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621555;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aporops";
}
