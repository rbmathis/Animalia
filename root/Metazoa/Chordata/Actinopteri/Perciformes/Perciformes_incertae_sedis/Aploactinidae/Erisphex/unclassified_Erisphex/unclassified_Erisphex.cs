using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Erisphex;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Erisphex.unclassified_Erisphex;

/// <summary>
/// Abstract class for unclassified Erisphex (no rank).
/// NCBI TaxId: 2677197
/// </summary>
public abstract class unclassified_Erisphex : Erisphex, Iunclassified_Erisphex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Erisphex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677197;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Erisphex";
}
