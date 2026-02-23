using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Lepidocharax;

/// <summary>
/// Abstract class for Lepidocharax (genus).
/// NCBI TaxId: 1463124
/// </summary>
public abstract class Lepidocharax : Stevardiidae, ILepidocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463124;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidocharax";

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
