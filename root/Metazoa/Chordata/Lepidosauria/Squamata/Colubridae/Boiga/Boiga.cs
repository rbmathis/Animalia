using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Boiga;

/// <summary>
/// Abstract class for Boiga (genus).
/// NCBI TaxId: 39142
/// </summary>
public abstract class Boiga : Colubridae, IBoiga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boiga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39142;

    /// <inheritdoc />
    public virtual string GenusName => "Boiga";

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
