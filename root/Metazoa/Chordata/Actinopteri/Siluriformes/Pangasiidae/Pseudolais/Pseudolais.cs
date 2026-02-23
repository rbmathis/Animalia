using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pseudolais;

/// <summary>
/// Abstract class for Pseudolais (genus).
/// NCBI TaxId: 365582
/// </summary>
public abstract class Pseudolais : Pangasiidae, IPseudolais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudolais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 365582;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudolais";

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
