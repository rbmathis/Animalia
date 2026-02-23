using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Hypopygus;

/// <summary>
/// Abstract class for Hypopygus (genus).
/// NCBI TaxId: 36691
/// </summary>
public abstract class Hypopygus : Rhamphichthyidae, IHypopygus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypopygus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36691;

    /// <inheritdoc />
    public virtual string GenusName => "Hypopygus";

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
