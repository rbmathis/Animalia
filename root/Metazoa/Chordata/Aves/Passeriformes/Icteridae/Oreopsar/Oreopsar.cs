using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Oreopsar;

/// <summary>
/// Abstract class for Oreopsar (genus).
/// NCBI TaxId: 84840
/// </summary>
public abstract class Oreopsar : Icteridae, IOreopsar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreopsar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84840;

    /// <inheritdoc />
    public virtual string GenusName => "Oreopsar";

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
