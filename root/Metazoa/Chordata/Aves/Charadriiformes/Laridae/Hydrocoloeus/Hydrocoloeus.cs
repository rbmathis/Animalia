using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Hydrocoloeus;

/// <summary>
/// Abstract class for Hydrocoloeus (genus).
/// NCBI TaxId: 559174
/// </summary>
public abstract class Hydrocoloeus : Laridae, IHydrocoloeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrocoloeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 559174;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrocoloeus";

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
