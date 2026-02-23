using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae.Petauroides;

/// <summary>
/// Abstract class for Petauroides (genus).
/// NCBI TaxId: 146631
/// </summary>
public abstract class Petauroides : Pseudocheiridae, IPetauroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petauroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 146631;

    /// <inheritdoc />
    public virtual string GenusName => "Petauroides";

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
