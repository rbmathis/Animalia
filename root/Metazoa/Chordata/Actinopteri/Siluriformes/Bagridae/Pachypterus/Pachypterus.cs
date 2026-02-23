using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Pachypterus;

/// <summary>
/// Abstract class for Pachypterus (genus).
/// NCBI TaxId: 1227136
/// </summary>
public abstract class Pachypterus : Bagridae, IPachypterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachypterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1227136;

    /// <inheritdoc />
    public virtual string GenusName => "Pachypterus";

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
