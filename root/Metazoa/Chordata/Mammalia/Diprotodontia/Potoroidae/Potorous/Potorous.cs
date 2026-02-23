using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae.Potorous;

/// <summary>
/// Abstract class for Potorous (genus).
/// NCBI TaxId: 9309
/// </summary>
public abstract class Potorous : Potoroidae, IPotorous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potorous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9309;

    /// <inheritdoc />
    public virtual string GenusName => "Potorous";

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
