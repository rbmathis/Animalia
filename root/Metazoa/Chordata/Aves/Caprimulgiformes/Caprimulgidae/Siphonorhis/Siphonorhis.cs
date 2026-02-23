using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Siphonorhis;

/// <summary>
/// Abstract class for Siphonorhis (genus).
/// NCBI TaxId: 723278
/// </summary>
public abstract class Siphonorhis : Caprimulgidae, ISiphonorhis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siphonorhis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723278;

    /// <inheritdoc />
    public virtual string GenusName => "Siphonorhis";

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
