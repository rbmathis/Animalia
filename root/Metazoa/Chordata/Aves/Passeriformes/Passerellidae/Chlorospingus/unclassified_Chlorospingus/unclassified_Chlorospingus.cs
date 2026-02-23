using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Chlorospingus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Chlorospingus.unclassified_Chlorospingus;

/// <summary>
/// Abstract class for unclassified Chlorospingus (no rank).
/// NCBI TaxId: 2806504
/// </summary>
public abstract class unclassified_Chlorospingus : Chlorospingus, Iunclassified_Chlorospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chlorospingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2806504;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chlorospingus";
}
