using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Trimerodytes;

/// <summary>
/// Abstract class for Trimerodytes (genus).
/// NCBI TaxId: 2678869
/// </summary>
public abstract class Trimerodytes : Colubridae, ITrimerodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trimerodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2678869;

    /// <inheritdoc />
    public virtual string GenusName => "Trimerodytes";

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
