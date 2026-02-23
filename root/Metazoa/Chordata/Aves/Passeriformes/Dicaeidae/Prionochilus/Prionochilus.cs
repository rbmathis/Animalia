using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicaeidae.Prionochilus;

/// <summary>
/// Abstract class for Prionochilus (genus).
/// NCBI TaxId: 667168
/// </summary>
public abstract class Prionochilus : Dicaeidae, IPrionochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prionochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 667168;

    /// <inheritdoc />
    public virtual string GenusName => "Prionochilus";

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
