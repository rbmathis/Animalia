using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Hoplisoma;

/// <summary>
/// Abstract class for Hoplisoma (genus).
/// NCBI TaxId: 3162715
/// </summary>
public abstract class Hoplisoma : Callichthyidae, IHoplisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3162715;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplisoma";

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
