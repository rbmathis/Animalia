using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Hirundichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Hirundichthys.rondeletii_species_complex;

/// <summary>
/// Abstract class for rondeletii species complex (no rank).
/// NCBI TaxId: 984887
/// </summary>
public abstract class rondeletii_species_complex : Hirundichthys, Irondeletii_species_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "rondeletii species complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 984887;

    /// <inheritdoc />
    public virtual string Description => "Taxon: rondeletii_species_complex";
}
