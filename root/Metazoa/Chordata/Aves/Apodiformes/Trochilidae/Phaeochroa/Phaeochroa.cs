using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Phaeochroa;

/// <summary>
/// Abstract class for Phaeochroa (genus).
/// NCBI TaxId: 2823181
/// </summary>
public abstract class Phaeochroa : Trochilidae, IPhaeochroa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaeochroa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823181;

    /// <inheritdoc />
    public virtual string GenusName => "Phaeochroa";

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
