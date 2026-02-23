using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Taurulus;

/// <summary>
/// Abstract class for Taurulus (genus).
/// NCBI TaxId: 61642
/// </summary>
public abstract class Taurulus : Cottidae, ITaurulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taurulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61642;

    /// <inheritdoc />
    public virtual string GenusName => "Taurulus";

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
