using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Brachypteraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Brachypteraciidae.Uratelornis;

/// <summary>
/// Abstract class for Uratelornis (genus).
/// NCBI TaxId: 188345
/// </summary>
public abstract class Uratelornis : Brachypteraciidae, IUratelornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uratelornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188345;

    /// <inheritdoc />
    public virtual string GenusName => "Uratelornis";

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
