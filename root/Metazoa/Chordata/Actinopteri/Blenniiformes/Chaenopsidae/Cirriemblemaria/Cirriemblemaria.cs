using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Cirriemblemaria;

/// <summary>
/// Abstract class for Cirriemblemaria (genus).
/// NCBI TaxId: 642445
/// </summary>
public abstract class Cirriemblemaria : Chaenopsidae, ICirriemblemaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirriemblemaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642445;

    /// <inheritdoc />
    public virtual string GenusName => "Cirriemblemaria";

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
