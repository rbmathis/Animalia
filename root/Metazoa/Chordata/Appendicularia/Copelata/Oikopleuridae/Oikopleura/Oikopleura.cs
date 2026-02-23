using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.Oikopleura;

/// <summary>
/// Abstract class for Oikopleura (genus).
/// NCBI TaxId: 34763
/// </summary>
public abstract class Oikopleura : Oikopleuridae, IOikopleura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oikopleura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34763;

    /// <inheritdoc />
    public virtual string GenusName => "Oikopleura";

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
