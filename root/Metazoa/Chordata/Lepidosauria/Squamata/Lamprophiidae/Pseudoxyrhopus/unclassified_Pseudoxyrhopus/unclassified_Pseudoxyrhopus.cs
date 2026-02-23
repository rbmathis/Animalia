using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Pseudoxyrhopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Pseudoxyrhopus.unclassified_Pseudoxyrhopus;

/// <summary>
/// Abstract class for unclassified Pseudoxyrhopus (no rank).
/// NCBI TaxId: 2632998
/// </summary>
public abstract class unclassified_Pseudoxyrhopus : Pseudoxyrhopus, Iunclassified_Pseudoxyrhopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoxyrhopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632998;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoxyrhopus";
}
