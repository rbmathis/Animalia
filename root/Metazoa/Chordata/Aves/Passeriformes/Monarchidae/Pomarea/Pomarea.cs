using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Pomarea;

/// <summary>
/// Abstract class for Pomarea (genus).
/// NCBI TaxId: 121424
/// </summary>
public abstract class Pomarea : Monarchidae, IPomarea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pomarea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121424;

    /// <inheritdoc />
    public virtual string GenusName => "Pomarea";

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
