using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae.Actophilornis;

/// <summary>
/// Abstract class for Actophilornis (genus).
/// NCBI TaxId: 118782
/// </summary>
public abstract class Actophilornis : Jacanidae, IActophilornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Actophilornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118782;

    /// <inheritdoc />
    public virtual string GenusName => "Actophilornis";

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
