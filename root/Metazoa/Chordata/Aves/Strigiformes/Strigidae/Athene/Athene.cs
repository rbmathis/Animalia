using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Athene;

/// <summary>
/// Abstract class for Athene (genus).
/// NCBI TaxId: 126785
/// </summary>
public abstract class Athene : Strigidae, IAthene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Athene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126785;

    /// <inheritdoc />
    public virtual string GenusName => "Athene";

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
