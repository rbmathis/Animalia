using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Chirostoma;

/// <summary>
/// Abstract class for Chirostoma (genus).
/// NCBI TaxId: 370628
/// </summary>
public abstract class Chirostoma : Atherinopsidae, IChirostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chirostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 370628;

    /// <inheritdoc />
    public virtual string GenusName => "Chirostoma";

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
