using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Dorcopsis;

/// <summary>
/// Abstract class for Dorcopsis (genus).
/// NCBI TaxId: 69267
/// </summary>
public abstract class Dorcopsis : Macropodidae, IDorcopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dorcopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69267;

    /// <inheritdoc />
    public virtual string GenusName => "Dorcopsis";

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
