using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Micrathene;

/// <summary>
/// Abstract class for Micrathene (genus).
/// NCBI TaxId: 57440
/// </summary>
public abstract class Micrathene : Strigidae, IMicrathene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micrathene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57440;

    /// <inheritdoc />
    public virtual string GenusName => "Micrathene";

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
