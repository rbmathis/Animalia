using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Aquarana;

/// <summary>
/// Abstract class for Aquarana (genus).
/// NCBI TaxId: 121236
/// </summary>
public abstract class Aquarana : Ranidae, IAquarana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aquarana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121236;

    /// <inheritdoc />
    public virtual string GenusName => "Aquarana";

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
