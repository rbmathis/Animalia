using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Limnonectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Limnonectes.Limnonectes_kuhlii_species_complex;

/// <summary>
/// Abstract class for Limnonectes kuhlii species complex (no rank).
/// NCBI TaxId: 797091
/// </summary>
public abstract class Limnonectes_kuhlii_species_complex : Limnonectes, ILimnonectes_kuhlii_species_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnonectes kuhlii species complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 797091;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Limnonectes_kuhlii_species_complex";
}
