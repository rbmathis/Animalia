using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Megalodoras;

/// <summary>
/// Abstract class for Megalodoras (genus).
/// NCBI TaxId: 238570
/// </summary>
public abstract class Megalodoras : Doradidae, IMegalodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238570;

    /// <inheritdoc />
    public virtual string GenusName => "Megalodoras";

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
