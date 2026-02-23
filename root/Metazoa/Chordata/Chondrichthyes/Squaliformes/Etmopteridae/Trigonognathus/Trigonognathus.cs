using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Trigonognathus;

/// <summary>
/// Abstract class for Trigonognathus (genus).
/// NCBI TaxId: 862905
/// </summary>
public abstract class Trigonognathus : Etmopteridae, ITrigonognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trigonognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862905;

    /// <inheritdoc />
    public virtual string GenusName => "Trigonognathus";

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
