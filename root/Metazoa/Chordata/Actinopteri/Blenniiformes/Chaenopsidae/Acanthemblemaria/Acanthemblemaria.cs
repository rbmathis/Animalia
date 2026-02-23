using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Acanthemblemaria;

/// <summary>
/// Abstract class for Acanthemblemaria (genus).
/// NCBI TaxId: 57775
/// </summary>
public abstract class Acanthemblemaria : Chaenopsidae, IAcanthemblemaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthemblemaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57775;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthemblemaria";

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
