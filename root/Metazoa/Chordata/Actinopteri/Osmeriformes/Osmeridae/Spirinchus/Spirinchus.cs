using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.Spirinchus;

/// <summary>
/// Abstract class for Spirinchus (genus).
/// NCBI TaxId: 136039
/// </summary>
public abstract class Spirinchus : Osmeridae, ISpirinchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spirinchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136039;

    /// <inheritdoc />
    public virtual string GenusName => "Spirinchus";

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
