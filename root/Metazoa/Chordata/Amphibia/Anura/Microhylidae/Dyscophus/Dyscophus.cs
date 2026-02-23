using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Dyscophus;

/// <summary>
/// Abstract class for Dyscophus (genus).
/// NCBI TaxId: 111068
/// </summary>
public abstract class Dyscophus : Microhylidae, IDyscophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dyscophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111068;

    /// <inheritdoc />
    public virtual string GenusName => "Dyscophus";

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
