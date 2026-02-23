using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Bothriechis;

/// <summary>
/// Abstract class for Bothriechis (genus).
/// NCBI TaxId: 44726
/// </summary>
public abstract class Bothriechis : Viperidae, IBothriechis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothriechis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44726;

    /// <inheritdoc />
    public virtual string GenusName => "Bothriechis";

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
