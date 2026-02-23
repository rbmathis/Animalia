using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Elseyornis;

/// <summary>
/// Abstract class for Elseyornis (genus).
/// NCBI TaxId: 50405
/// </summary>
public abstract class Elseyornis : Charadriidae, IElseyornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elseyornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50405;

    /// <inheritdoc />
    public virtual string GenusName => "Elseyornis";

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
