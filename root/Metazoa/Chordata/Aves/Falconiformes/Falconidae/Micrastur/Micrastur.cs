using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Micrastur;

/// <summary>
/// Abstract class for Micrastur (genus).
/// NCBI TaxId: 56333
/// </summary>
public abstract class Micrastur : Falconidae, IMicrastur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micrastur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56333;

    /// <inheritdoc />
    public virtual string GenusName => "Micrastur";

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
