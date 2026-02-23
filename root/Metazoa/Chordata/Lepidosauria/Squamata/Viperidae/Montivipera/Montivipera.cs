using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Montivipera;

/// <summary>
/// Abstract class for Montivipera (genus).
/// NCBI TaxId: 1170831
/// </summary>
public abstract class Montivipera : Viperidae, IMontivipera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Montivipera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1170831;

    /// <inheritdoc />
    public virtual string GenusName => "Montivipera";

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
