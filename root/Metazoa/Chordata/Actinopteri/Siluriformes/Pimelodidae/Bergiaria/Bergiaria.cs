using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Bergiaria;

/// <summary>
/// Abstract class for Bergiaria (genus).
/// NCBI TaxId: 1053606
/// </summary>
public abstract class Bergiaria : Pimelodidae, IBergiaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bergiaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1053606;

    /// <inheritdoc />
    public virtual string GenusName => "Bergiaria";

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
