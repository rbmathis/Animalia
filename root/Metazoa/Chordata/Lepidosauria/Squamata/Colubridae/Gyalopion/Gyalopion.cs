using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Gyalopion;

/// <summary>
/// Abstract class for Gyalopion (genus).
/// NCBI TaxId: 703963
/// </summary>
public abstract class Gyalopion : Colubridae, IGyalopion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gyalopion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 703963;

    /// <inheritdoc />
    public virtual string GenusName => "Gyalopion";

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
