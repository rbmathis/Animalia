using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua.unclassified_Cacatua;

/// <summary>
/// Abstract class for unclassified Cacatua (no rank).
/// NCBI TaxId: 2639382
/// </summary>
public abstract class unclassified_Cacatua : Cacatua, Iunclassified_Cacatua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cacatua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639382;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cacatua";
}
