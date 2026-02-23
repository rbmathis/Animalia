using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Drymarchon;

/// <summary>
/// Abstract class for Drymarchon (genus).
/// NCBI TaxId: 186582
/// </summary>
public abstract class Drymarchon : Colubridae, IDrymarchon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drymarchon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186582;

    /// <inheritdoc />
    public virtual string GenusName => "Drymarchon";

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
