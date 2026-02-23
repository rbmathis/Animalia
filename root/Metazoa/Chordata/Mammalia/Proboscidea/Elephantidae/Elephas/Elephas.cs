using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Elephas;

/// <summary>
/// Abstract class for Elephas (genus).
/// NCBI TaxId: 9782
/// </summary>
public abstract class Elephas : Elephantidae, IElephas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elephas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9782;

    /// <inheritdoc />
    public virtual string GenusName => "Elephas";

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
