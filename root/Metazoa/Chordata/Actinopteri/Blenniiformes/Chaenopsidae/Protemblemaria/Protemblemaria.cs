using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Protemblemaria;

/// <summary>
/// Abstract class for Protemblemaria (genus).
/// NCBI TaxId: 642459
/// </summary>
public abstract class Protemblemaria : Chaenopsidae, IProtemblemaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protemblemaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642459;

    /// <inheritdoc />
    public virtual string GenusName => "Protemblemaria";

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
