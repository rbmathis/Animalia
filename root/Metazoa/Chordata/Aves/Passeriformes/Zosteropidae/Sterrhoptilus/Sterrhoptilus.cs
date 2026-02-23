using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Sterrhoptilus;

/// <summary>
/// Abstract class for Sterrhoptilus (genus).
/// NCBI TaxId: 2585819
/// </summary>
public abstract class Sterrhoptilus : Zosteropidae, ISterrhoptilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sterrhoptilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2585819;

    /// <inheritdoc />
    public virtual string GenusName => "Sterrhoptilus";

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
