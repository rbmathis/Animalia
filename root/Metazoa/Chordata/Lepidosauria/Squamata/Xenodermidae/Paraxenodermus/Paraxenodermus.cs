using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermidae.Paraxenodermus;

/// <summary>
/// Abstract class for Paraxenodermus (genus).
/// NCBI TaxId: 3148944
/// </summary>
public abstract class Paraxenodermus : Xenodermidae, IParaxenodermus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraxenodermus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148944;

    /// <inheritdoc />
    public virtual string GenusName => "Paraxenodermus";

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
