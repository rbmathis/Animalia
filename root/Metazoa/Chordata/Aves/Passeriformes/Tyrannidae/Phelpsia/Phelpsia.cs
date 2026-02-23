using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Phelpsia;

/// <summary>
/// Abstract class for Phelpsia (genus).
/// NCBI TaxId: 2767943
/// </summary>
public abstract class Phelpsia : Tyrannidae, IPhelpsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phelpsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767943;

    /// <inheritdoc />
    public virtual string GenusName => "Phelpsia";

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
