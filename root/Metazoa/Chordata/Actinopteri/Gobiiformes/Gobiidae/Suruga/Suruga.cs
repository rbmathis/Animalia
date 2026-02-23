using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Suruga;

/// <summary>
/// Abstract class for Suruga (genus).
/// NCBI TaxId: 1642173
/// </summary>
public abstract class Suruga : Gobiidae, ISuruga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Suruga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642173;

    /// <inheritdoc />
    public virtual string GenusName => "Suruga";

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
