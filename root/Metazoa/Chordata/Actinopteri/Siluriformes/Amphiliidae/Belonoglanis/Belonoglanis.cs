using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Belonoglanis;

/// <summary>
/// Abstract class for Belonoglanis (genus).
/// NCBI TaxId: 390403
/// </summary>
public abstract class Belonoglanis : Amphiliidae, IBelonoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belonoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390403;

    /// <inheritdoc />
    public virtual string GenusName => "Belonoglanis";

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
