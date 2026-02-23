using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Mellisuga;

/// <summary>
/// Abstract class for Mellisuga (genus).
/// NCBI TaxId: 1507478
/// </summary>
public abstract class Mellisuga : Trochilidae, IMellisuga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mellisuga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1507478;

    /// <inheritdoc />
    public virtual string GenusName => "Mellisuga";

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
