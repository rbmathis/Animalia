using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae.Pseudochirops;

/// <summary>
/// Abstract class for Pseudochirops (genus).
/// NCBI TaxId: 37890
/// </summary>
public abstract class Pseudochirops : Pseudocheiridae, IPseudochirops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudochirops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37890;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudochirops";

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
