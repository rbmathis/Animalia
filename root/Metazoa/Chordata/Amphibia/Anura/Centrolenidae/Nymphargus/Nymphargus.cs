using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Nymphargus;

/// <summary>
/// Abstract class for Nymphargus (genus).
/// NCBI TaxId: 507701
/// </summary>
public abstract class Nymphargus : Centrolenidae, INymphargus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nymphargus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 507701;

    /// <inheritdoc />
    public virtual string GenusName => "Nymphargus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
