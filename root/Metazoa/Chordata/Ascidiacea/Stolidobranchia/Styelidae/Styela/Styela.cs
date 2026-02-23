using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Styela;

/// <summary>
/// Abstract class for Styela (genus).
/// NCBI TaxId: 7724
/// </summary>
public abstract class Styela : Styelidae, IStyela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Styela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7724;

    /// <inheritdoc />
    public virtual string GenusName => "Styela";

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
