using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Cacicus;

/// <summary>
/// Abstract class for Cacicus (genus).
/// NCBI TaxId: 84787
/// </summary>
public abstract class Cacicus : Icteridae, ICacicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cacicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84787;

    /// <inheritdoc />
    public virtual string GenusName => "Cacicus";

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
