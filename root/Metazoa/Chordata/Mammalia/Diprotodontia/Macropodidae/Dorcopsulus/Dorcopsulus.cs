using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Dorcopsulus;

/// <summary>
/// Abstract class for Dorcopsulus (genus).
/// NCBI TaxId: 69269
/// </summary>
public abstract class Dorcopsulus : Macropodidae, IDorcopsulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dorcopsulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69269;

    /// <inheritdoc />
    public virtual string GenusName => "Dorcopsulus";

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
