using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Mccoskerichthys;

/// <summary>
/// Abstract class for Mccoskerichthys (genus).
/// NCBI TaxId: 642457
/// </summary>
public abstract class Mccoskerichthys : Chaenopsidae, IMccoskerichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mccoskerichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642457;

    /// <inheritdoc />
    public virtual string GenusName => "Mccoskerichthys";

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
