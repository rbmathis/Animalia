using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dendropsophus;

/// <summary>
/// Abstract class for Dendropsophus (genus).
/// NCBI TaxId: 374069
/// </summary>
public abstract class Dendropsophus : Hylidae, IDendropsophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendropsophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374069;

    /// <inheritdoc />
    public virtual string GenusName => "Dendropsophus";

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
