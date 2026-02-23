using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae.Discopyge;

/// <summary>
/// Abstract class for Discopyge (genus).
/// NCBI TaxId: 7784
/// </summary>
public abstract class Discopyge : Narcinidae, IDiscopyge
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Discopyge";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7784;

    /// <inheritdoc />
    public virtual string GenusName => "Discopyge";

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
