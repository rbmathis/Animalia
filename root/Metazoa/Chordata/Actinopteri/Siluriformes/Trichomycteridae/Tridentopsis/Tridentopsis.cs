using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Tridentopsis;

/// <summary>
/// Abstract class for Tridentopsis (genus).
/// NCBI TaxId: 3363495
/// </summary>
public abstract class Tridentopsis : Trichomycteridae, ITridentopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tridentopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363495;

    /// <inheritdoc />
    public virtual string GenusName => "Tridentopsis";

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
