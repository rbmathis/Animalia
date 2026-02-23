using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Paraploactis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Paraploactis.unclassified_Paraploactis;

/// <summary>
/// Abstract class for unclassified Paraploactis (no rank).
/// NCBI TaxId: 3446858
/// </summary>
public abstract class unclassified_Paraploactis : Paraploactis, Iunclassified_Paraploactis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraploactis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446858;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraploactis";
}
