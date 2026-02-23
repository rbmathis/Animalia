using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Retropinnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Retropinnidae.Retropinna;

/// <summary>
/// Abstract class for Retropinna (genus).
/// NCBI TaxId: 89572
/// </summary>
public abstract class Retropinna : Retropinnidae, IRetropinna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Retropinna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89572;

    /// <inheritdoc />
    public virtual string GenusName => "Retropinna";

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
