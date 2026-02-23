using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Pelias;

/// <summary>
/// Abstract class for Pelias (genus).
/// NCBI TaxId: 2493203
/// </summary>
public abstract class Pelias : Viperidae, IPelias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2493203;

    /// <inheritdoc />
    public virtual string GenusName => "Pelias";

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
