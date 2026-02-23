using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Grayia;

/// <summary>
/// Abstract class for Grayia (genus).
/// NCBI TaxId: 121294
/// </summary>
public abstract class Grayia : Colubridae, IGrayia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grayia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121294;

    /// <inheritdoc />
    public virtual string GenusName => "Grayia";

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
