using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Hypnale;

/// <summary>
/// Abstract class for Hypnale (genus).
/// NCBI TaxId: 44719
/// </summary>
public abstract class Hypnale : Viperidae, IHypnale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypnale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44719;

    /// <inheritdoc />
    public virtual string GenusName => "Hypnale";

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
