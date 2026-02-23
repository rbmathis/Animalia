using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Diplolaemus;

/// <summary>
/// Abstract class for Diplolaemus (genus).
/// NCBI TaxId: 75279
/// </summary>
public abstract class Diplolaemus : Leiosauridae, IDiplolaemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplolaemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75279;

    /// <inheritdoc />
    public virtual string GenusName => "Diplolaemus";

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
