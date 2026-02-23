using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rallus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rallus.unclassified_Rallus;

/// <summary>
/// Abstract class for unclassified Rallus (no rank).
/// NCBI TaxId: 2878412
/// </summary>
public abstract class unclassified_Rallus : Rallus, Iunclassified_Rallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878412;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rallus";
}
