using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Emblemaria;

/// <summary>
/// Abstract class for Emblemaria (genus).
/// NCBI TaxId: 57793
/// </summary>
public abstract class Emblemaria : Chaenopsidae, IEmblemaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emblemaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57793;

    /// <inheritdoc />
    public virtual string GenusName => "Emblemaria";

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
