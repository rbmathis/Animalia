using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Pseudotriakidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Pseudotriakidae.Pseudotriakis;

/// <summary>
/// Abstract class for Pseudotriakis (genus).
/// NCBI TaxId: 172662
/// </summary>
public abstract class Pseudotriakis : Pseudotriakidae, IPseudotriakis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotriakis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172662;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotriakis";

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
