using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae.Zeugopterus;

/// <summary>
/// Abstract class for Zeugopterus (genus).
/// NCBI TaxId: 526622
/// </summary>
public abstract class Zeugopterus : Scophthalmidae, IZeugopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zeugopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 526622;

    /// <inheritdoc />
    public virtual string GenusName => "Zeugopterus";

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
