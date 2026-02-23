using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae.Pletholax;

/// <summary>
/// Abstract class for Pletholax (genus).
/// NCBI TaxId: 207564
/// </summary>
public abstract class Pletholax : Pygopodidae, IPletholax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pletholax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 207564;

    /// <inheritdoc />
    public virtual string GenusName => "Pletholax";

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
