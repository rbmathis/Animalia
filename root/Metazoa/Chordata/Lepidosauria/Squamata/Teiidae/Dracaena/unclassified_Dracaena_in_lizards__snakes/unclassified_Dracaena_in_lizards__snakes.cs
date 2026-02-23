using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Dracaena;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Dracaena.unclassified_Dracaena_in_lizards__snakes;

/// <summary>
/// Abstract class for unclassified Dracaena (in: lizards & snakes) (no rank).
/// NCBI TaxId: 2677199
/// </summary>
public abstract class unclassified_Dracaena_in_lizards__snakes : Dracaena, Iunclassified_Dracaena_in_lizards__snakes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dracaena (in: lizards & snakes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677199;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dracaena_in_lizards__snakes";
}
