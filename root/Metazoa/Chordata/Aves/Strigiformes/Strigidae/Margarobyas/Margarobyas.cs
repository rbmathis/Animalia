using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Margarobyas;

/// <summary>
/// Abstract class for Margarobyas (genus).
/// NCBI TaxId: 2653986
/// </summary>
public abstract class Margarobyas : Strigidae, IMargarobyas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Margarobyas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2653986;

    /// <inheritdoc />
    public virtual string GenusName => "Margarobyas";

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
