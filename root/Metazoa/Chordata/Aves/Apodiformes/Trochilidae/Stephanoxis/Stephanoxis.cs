using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Stephanoxis;

/// <summary>
/// Abstract class for Stephanoxis (genus).
/// NCBI TaxId: 555348
/// </summary>
public abstract class Stephanoxis : Trochilidae, IStephanoxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stephanoxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555348;

    /// <inheritdoc />
    public virtual string GenusName => "Stephanoxis";

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
