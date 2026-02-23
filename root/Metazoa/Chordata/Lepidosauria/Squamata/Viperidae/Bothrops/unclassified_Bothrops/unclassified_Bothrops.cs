using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Bothrops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Bothrops.unclassified_Bothrops;

/// <summary>
/// Abstract class for unclassified Bothrops (no rank).
/// NCBI TaxId: 2631046
/// </summary>
public abstract class unclassified_Bothrops : Bothrops, Iunclassified_Bothrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bothrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631046;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bothrops";
}
