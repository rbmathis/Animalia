using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Paradoxophyla;

/// <summary>
/// Abstract class for Paradoxophyla (genus).
/// NCBI TaxId: 303958
/// </summary>
public abstract class Paradoxophyla : Microhylidae, IParadoxophyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradoxophyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303958;

    /// <inheritdoc />
    public virtual string GenusName => "Paradoxophyla";

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
