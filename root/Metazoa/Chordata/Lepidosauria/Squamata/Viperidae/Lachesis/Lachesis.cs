using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Lachesis;

/// <summary>
/// Abstract class for Lachesis (genus).
/// NCBI TaxId: 8751
/// </summary>
public abstract class Lachesis : Viperidae, ILachesis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lachesis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8751;

    /// <inheritdoc />
    public virtual string GenusName => "Lachesis";

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
