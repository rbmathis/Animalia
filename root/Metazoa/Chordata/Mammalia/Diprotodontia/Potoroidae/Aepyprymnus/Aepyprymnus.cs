using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae.Aepyprymnus;

/// <summary>
/// Abstract class for Aepyprymnus (genus).
/// NCBI TaxId: 38597
/// </summary>
public abstract class Aepyprymnus : Potoroidae, IAepyprymnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aepyprymnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38597;

    /// <inheritdoc />
    public virtual string GenusName => "Aepyprymnus";

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
