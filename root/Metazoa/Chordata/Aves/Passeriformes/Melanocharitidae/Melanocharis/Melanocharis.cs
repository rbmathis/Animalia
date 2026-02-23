using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae.Melanocharis;

/// <summary>
/// Abstract class for Melanocharis (genus).
/// NCBI TaxId: 175123
/// </summary>
public abstract class Melanocharis : Melanocharitidae, IMelanocharis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanocharis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175123;

    /// <inheritdoc />
    public virtual string GenusName => "Melanocharis";

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
