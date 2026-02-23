using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Liophidium;

/// <summary>
/// Abstract class for Liophidium (genus).
/// NCBI TaxId: 224556
/// </summary>
public abstract class Liophidium : Lamprophiidae, ILiophidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liophidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224556;

    /// <inheritdoc />
    public virtual string GenusName => "Liophidium";

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
