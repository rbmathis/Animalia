using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Chaetophractus;

/// <summary>
/// Abstract class for Chaetophractus (genus).
/// NCBI TaxId: 29079
/// </summary>
public abstract class Chaetophractus : Chlamyphoridae, IChaetophractus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetophractus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29079;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetophractus";

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
