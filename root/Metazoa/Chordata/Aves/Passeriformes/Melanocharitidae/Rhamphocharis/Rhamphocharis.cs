using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae.Rhamphocharis;

/// <summary>
/// Abstract class for Rhamphocharis (genus).
/// NCBI TaxId: 2794621
/// </summary>
public abstract class Rhamphocharis : Melanocharitidae, IRhamphocharis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamphocharis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2794621;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamphocharis";

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
