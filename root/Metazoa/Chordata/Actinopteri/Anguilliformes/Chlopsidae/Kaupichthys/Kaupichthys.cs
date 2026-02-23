using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae.Kaupichthys;

/// <summary>
/// Abstract class for Kaupichthys (genus).
/// NCBI TaxId: 139720
/// </summary>
public abstract class Kaupichthys : Chlopsidae, IKaupichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kaupichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 139720;

    /// <inheritdoc />
    public virtual string GenusName => "Kaupichthys";

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
