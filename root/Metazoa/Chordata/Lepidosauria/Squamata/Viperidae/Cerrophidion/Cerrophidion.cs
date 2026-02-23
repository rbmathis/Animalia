using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Cerrophidion;

/// <summary>
/// Abstract class for Cerrophidion (genus).
/// NCBI TaxId: 44721
/// </summary>
public abstract class Cerrophidion : Viperidae, ICerrophidion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cerrophidion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44721;

    /// <inheritdoc />
    public virtual string GenusName => "Cerrophidion";

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
