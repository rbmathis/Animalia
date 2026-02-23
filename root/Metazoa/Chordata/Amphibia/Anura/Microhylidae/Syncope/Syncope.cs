using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Syncope;

/// <summary>
/// Abstract class for Syncope (genus).
/// NCBI TaxId: 1271638
/// </summary>
public abstract class Syncope : Microhylidae, ISyncope
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syncope";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1271638;

    /// <inheritdoc />
    public virtual string GenusName => "Syncope";

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
