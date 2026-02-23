using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Julianus;

/// <summary>
/// Abstract class for Julianus (genus).
/// NCBI TaxId: 3372747
/// </summary>
public abstract class Julianus : Hylidae, IJulianus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Julianus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3372747;

    /// <inheritdoc />
    public virtual string GenusName => "Julianus";

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
