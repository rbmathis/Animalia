using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Harpesaurus;

/// <summary>
/// Abstract class for Harpesaurus (genus).
/// NCBI TaxId: 1544899
/// </summary>
public abstract class Harpesaurus : Agamidae, IHarpesaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpesaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544899;

    /// <inheritdoc />
    public virtual string GenusName => "Harpesaurus";

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
