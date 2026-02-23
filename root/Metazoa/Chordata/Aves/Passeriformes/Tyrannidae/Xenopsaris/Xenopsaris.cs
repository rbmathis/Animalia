using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Xenopsaris;

/// <summary>
/// Abstract class for Xenopsaris (genus).
/// NCBI TaxId: 369620
/// </summary>
public abstract class Xenopsaris : Tyrannidae, IXenopsaris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenopsaris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369620;

    /// <inheritdoc />
    public virtual string GenusName => "Xenopsaris";

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
