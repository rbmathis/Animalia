using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.Mesoikopleura;

/// <summary>
/// Abstract class for Mesoikopleura (genus).
/// NCBI TaxId: 2547647
/// </summary>
public abstract class Mesoikopleura : Oikopleuridae, IMesoikopleura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesoikopleura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2547647;

    /// <inheritdoc />
    public virtual string GenusName => "Mesoikopleura";

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
