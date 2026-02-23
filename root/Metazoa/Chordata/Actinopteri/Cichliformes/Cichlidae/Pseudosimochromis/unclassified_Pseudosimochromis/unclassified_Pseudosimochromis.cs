using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pseudosimochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pseudosimochromis.unclassified_Pseudosimochromis;

/// <summary>
/// Abstract class for unclassified Pseudosimochromis (no rank).
/// NCBI TaxId: 3015839
/// </summary>
public abstract class unclassified_Pseudosimochromis : Pseudosimochromis, Iunclassified_Pseudosimochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudosimochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3015839;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudosimochromis";
}
