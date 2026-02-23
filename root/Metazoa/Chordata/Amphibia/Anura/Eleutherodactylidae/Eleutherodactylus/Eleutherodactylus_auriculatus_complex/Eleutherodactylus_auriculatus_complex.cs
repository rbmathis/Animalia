using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Eleutherodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Eleutherodactylus.Eleutherodactylus_auriculatus_complex;

/// <summary>
/// Abstract class for Eleutherodactylus auriculatus complex (no rank).
/// NCBI TaxId: 650991
/// </summary>
public abstract class Eleutherodactylus_auriculatus_complex : Eleutherodactylus, IEleutherodactylus_auriculatus_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleutherodactylus auriculatus complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 650991;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Eleutherodactylus_auriculatus_complex";
}
