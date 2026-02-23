using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elusor;

/// <summary>
/// Abstract class for Elusor (genus).
/// NCBI TaxId: 44529
/// </summary>
public abstract class Elusor : Chelidae, IElusor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elusor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44529;

    /// <inheritdoc />
    public virtual string GenusName => "Elusor";

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
