using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Boa;

/// <summary>
/// Abstract class for Boa (genus).
/// NCBI TaxId: 8573
/// </summary>
public abstract class Boa : Boidae, IBoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8573;

    /// <inheritdoc />
    public virtual string GenusName => "Boa";

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
