using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Abronia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Abronia.unclassified_Abronia_in_lizards__snakes;

/// <summary>
/// Abstract class for unclassified Abronia (in: lizards & snakes) (no rank).
/// NCBI TaxId: 2676921
/// </summary>
public abstract class unclassified_Abronia_in_lizards__snakes : Abronia, Iunclassified_Abronia_in_lizards__snakes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Abronia (in: lizards & snakes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2676921;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Abronia_in_lizards__snakes";
}
