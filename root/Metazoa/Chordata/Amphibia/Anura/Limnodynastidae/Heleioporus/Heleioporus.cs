using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Heleioporus;

/// <summary>
/// Abstract class for Heleioporus (genus).
/// NCBI TaxId: 356300
/// </summary>
public abstract class Heleioporus : Limnodynastidae, IHeleioporus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heleioporus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356300;

    /// <inheritdoc />
    public virtual string GenusName => "Heleioporus";

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
