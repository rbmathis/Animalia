using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Donacobius;

/// <summary>
/// Abstract class for Donacobius (genus).
/// NCBI TaxId: 237419
/// </summary>
public abstract class Donacobius : Mimidae, IDonacobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Donacobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237419;

    /// <inheritdoc />
    public virtual string GenusName => "Donacobius";

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
