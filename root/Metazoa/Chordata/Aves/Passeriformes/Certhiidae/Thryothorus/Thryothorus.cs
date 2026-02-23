using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Thryothorus;

/// <summary>
/// Abstract class for Thryothorus (genus).
/// NCBI TaxId: 74199
/// </summary>
public abstract class Thryothorus : Certhiidae, IThryothorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thryothorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74199;

    /// <inheritdoc />
    public virtual string GenusName => "Thryothorus";

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
