using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Pselliophorus;

/// <summary>
/// Abstract class for Pselliophorus (genus).
/// NCBI TaxId: 380365
/// </summary>
public abstract class Pselliophorus : Passerellidae, IPselliophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pselliophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 380365;

    /// <inheritdoc />
    public virtual string GenusName => "Pselliophorus";

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
