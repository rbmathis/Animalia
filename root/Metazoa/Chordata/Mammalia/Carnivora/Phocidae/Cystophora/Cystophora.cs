using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Cystophora;

/// <summary>
/// Abstract class for Cystophora (genus).
/// NCBI TaxId: 39181
/// </summary>
public abstract class Cystophora : Phocidae, ICystophora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cystophora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39181;

    /// <inheritdoc />
    public virtual string GenusName => "Cystophora";

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
