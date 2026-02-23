using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae.Pseudochirulus;

/// <summary>
/// Abstract class for Pseudochirulus (genus).
/// NCBI TaxId: 596259
/// </summary>
public abstract class Pseudochirulus : Pseudocheiridae, IPseudochirulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudochirulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 596259;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudochirulus";

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
