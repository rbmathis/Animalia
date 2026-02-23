using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Tachornis;

/// <summary>
/// Abstract class for Tachornis (genus).
/// NCBI TaxId: 190699
/// </summary>
public abstract class Tachornis : Apodidae, ITachornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190699;

    /// <inheritdoc />
    public virtual string GenusName => "Tachornis";

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
