using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Sphyrnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Sphyrnidae.Eusphyra;

/// <summary>
/// Abstract class for Eusphyra (genus).
/// NCBI TaxId: 376649
/// </summary>
public abstract class Eusphyra : Sphyrnidae, IEusphyra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eusphyra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376649;

    /// <inheritdoc />
    public virtual string GenusName => "Eusphyra";

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
