using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Bipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Bipedidae.Bipes;

/// <summary>
/// Abstract class for Bipes (genus).
/// NCBI TaxId: 52187
/// </summary>
public abstract class Bipes : Bipedidae, IBipes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bipes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52187;

    /// <inheritdoc />
    public virtual string GenusName => "Bipes";

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
