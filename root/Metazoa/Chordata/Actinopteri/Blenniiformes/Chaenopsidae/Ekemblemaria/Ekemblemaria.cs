using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Ekemblemaria;

/// <summary>
/// Abstract class for Ekemblemaria (genus).
/// NCBI TaxId: 642447
/// </summary>
public abstract class Ekemblemaria : Chaenopsidae, IEkemblemaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ekemblemaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642447;

    /// <inheritdoc />
    public virtual string GenusName => "Ekemblemaria";

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
