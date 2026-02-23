using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Stiphodon;

/// <summary>
/// Abstract class for Stiphodon (genus).
/// NCBI TaxId: 150329
/// </summary>
public abstract class Stiphodon : Gobiidae, IStiphodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stiphodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150329;

    /// <inheritdoc />
    public virtual string GenusName => "Stiphodon";

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
