using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Djokoiskandarus;

/// <summary>
/// Abstract class for Djokoiskandarus (genus).
/// NCBI TaxId: 1544567
/// </summary>
public abstract class Djokoiskandarus : Homalopsidae, IDjokoiskandarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Djokoiskandarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544567;

    /// <inheritdoc />
    public virtual string GenusName => "Djokoiskandarus";

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
