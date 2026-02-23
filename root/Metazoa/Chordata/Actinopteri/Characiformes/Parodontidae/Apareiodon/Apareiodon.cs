using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae.Apareiodon;

/// <summary>
/// Abstract class for Apareiodon (genus).
/// NCBI TaxId: 42611
/// </summary>
public abstract class Apareiodon : Parodontidae, IApareiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apareiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42611;

    /// <inheritdoc />
    public virtual string GenusName => "Apareiodon";

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
