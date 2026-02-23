using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Mustelirallus;

/// <summary>
/// Abstract class for Mustelirallus (genus).
/// NCBI TaxId: 3150826
/// </summary>
public abstract class Mustelirallus : Rallidae, IMustelirallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mustelirallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150826;

    /// <inheritdoc />
    public virtual string GenusName => "Mustelirallus";

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
