using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pseudoplatystoma;

/// <summary>
/// Abstract class for Pseudoplatystoma (genus).
/// NCBI TaxId: 309910
/// </summary>
public abstract class Pseudoplatystoma : Pimelodidae, IPseudoplatystoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoplatystoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 309910;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoplatystoma";

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
