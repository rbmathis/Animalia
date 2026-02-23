using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Gloydius;

/// <summary>
/// Abstract class for Gloydius (genus).
/// NCBI TaxId: 51647
/// </summary>
public abstract class Gloydius : Viperidae, IGloydius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gloydius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51647;

    /// <inheritdoc />
    public virtual string GenusName => "Gloydius";

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
