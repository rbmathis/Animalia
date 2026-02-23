using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Maracaiba;

/// <summary>
/// Abstract class for Maracaiba (genus).
/// NCBI TaxId: 1206900
/// </summary>
public abstract class Maracaiba : Scincidae, IMaracaiba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Maracaiba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1206900;

    /// <inheritdoc />
    public virtual string GenusName => "Maracaiba";

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
