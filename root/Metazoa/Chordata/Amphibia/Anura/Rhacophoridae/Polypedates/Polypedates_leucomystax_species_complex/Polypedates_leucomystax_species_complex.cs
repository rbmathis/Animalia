using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Polypedates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Polypedates.Polypedates_leucomystax_species_complex;

/// <summary>
/// Abstract class for Polypedates leucomystax species complex (no rank).
/// NCBI TaxId: 697138
/// </summary>
public abstract class Polypedates_leucomystax_species_complex : Polypedates, IPolypedates_leucomystax_species_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polypedates leucomystax species complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 697138;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Polypedates_leucomystax_species_complex";
}
