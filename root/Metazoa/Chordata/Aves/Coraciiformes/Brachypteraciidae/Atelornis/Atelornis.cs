using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Brachypteraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Brachypteraciidae.Atelornis;

/// <summary>
/// Abstract class for Atelornis (genus).
/// NCBI TaxId: 188334
/// </summary>
public abstract class Atelornis : Brachypteraciidae, IAtelornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atelornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188334;

    /// <inheritdoc />
    public virtual string GenusName => "Atelornis";

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
