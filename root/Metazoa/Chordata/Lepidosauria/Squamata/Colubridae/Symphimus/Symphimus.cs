using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Symphimus;

/// <summary>
/// Abstract class for Symphimus (genus).
/// NCBI TaxId: 1545891
/// </summary>
public abstract class Symphimus : Colubridae, ISymphimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Symphimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545891;

    /// <inheritdoc />
    public virtual string GenusName => "Symphimus";

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
