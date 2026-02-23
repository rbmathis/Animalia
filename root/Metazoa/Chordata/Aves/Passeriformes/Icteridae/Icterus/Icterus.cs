using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Icterus;

/// <summary>
/// Abstract class for Icterus (genus).
/// NCBI TaxId: 84804
/// </summary>
public abstract class Icterus : Icteridae, IIcterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Icterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84804;

    /// <inheritdoc />
    public virtual string GenusName => "Icterus";

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
