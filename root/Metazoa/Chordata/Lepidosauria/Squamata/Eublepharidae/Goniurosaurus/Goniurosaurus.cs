using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae.Goniurosaurus;

/// <summary>
/// Abstract class for Goniurosaurus (genus).
/// NCBI TaxId: 96738
/// </summary>
public abstract class Goniurosaurus : Eublepharidae, IGoniurosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Goniurosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96738;

    /// <inheritdoc />
    public virtual string GenusName => "Goniurosaurus";

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
