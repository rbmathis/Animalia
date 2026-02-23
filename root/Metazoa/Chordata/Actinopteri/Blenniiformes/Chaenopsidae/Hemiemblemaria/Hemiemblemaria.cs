using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Hemiemblemaria;

/// <summary>
/// Abstract class for Hemiemblemaria (genus).
/// NCBI TaxId: 642453
/// </summary>
public abstract class Hemiemblemaria : Chaenopsidae, IHemiemblemaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiemblemaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642453;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiemblemaria";

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
