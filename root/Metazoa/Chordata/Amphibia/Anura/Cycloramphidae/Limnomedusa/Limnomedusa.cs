using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae.Limnomedusa;

/// <summary>
/// Abstract class for Limnomedusa (genus).
/// NCBI TaxId: 318364
/// </summary>
public abstract class Limnomedusa : Cycloramphidae, ILimnomedusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnomedusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318364;

    /// <inheritdoc />
    public virtual string GenusName => "Limnomedusa";

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
