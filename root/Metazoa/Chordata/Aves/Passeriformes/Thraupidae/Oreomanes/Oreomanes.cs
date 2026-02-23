using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Oreomanes;

/// <summary>
/// Abstract class for Oreomanes (genus).
/// NCBI TaxId: 62230
/// </summary>
public abstract class Oreomanes : Thraupidae, IOreomanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreomanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62230;

    /// <inheritdoc />
    public virtual string GenusName => "Oreomanes";

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
