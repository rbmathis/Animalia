using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hylarana;

/// <summary>
/// Abstract class for Hylarana (genus).
/// NCBI TaxId: 1008893
/// </summary>
public abstract class Hylarana : Ranidae, IHylarana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylarana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1008893;

    /// <inheritdoc />
    public virtual string GenusName => "Hylarana";

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
