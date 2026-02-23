using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Myornis;

/// <summary>
/// Abstract class for Myornis (genus).
/// NCBI TaxId: 42819
/// </summary>
public abstract class Myornis : Rhinocryptidae, IMyornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42819;

    /// <inheritdoc />
    public virtual string GenusName => "Myornis";

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
