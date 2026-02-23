using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Megaelosia;

/// <summary>
/// Abstract class for Megaelosia (genus).
/// NCBI TaxId: 209669
/// </summary>
public abstract class Megaelosia : Hylodidae, IMegaelosia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megaelosia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209669;

    /// <inheritdoc />
    public virtual string GenusName => "Megaelosia";

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
