using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Arizona;

/// <summary>
/// Abstract class for Arizona (genus).
/// NCBI TaxId: 94892
/// </summary>
public abstract class Arizona : Colubridae, IArizona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arizona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94892;

    /// <inheritdoc />
    public virtual string GenusName => "Arizona";

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
