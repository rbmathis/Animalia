using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Pseudophilautus;

/// <summary>
/// Abstract class for Pseudophilautus (genus).
/// NCBI TaxId: 979144
/// </summary>
public abstract class Pseudophilautus : Rhacophoridae, IPseudophilautus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudophilautus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 979144;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudophilautus";

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
