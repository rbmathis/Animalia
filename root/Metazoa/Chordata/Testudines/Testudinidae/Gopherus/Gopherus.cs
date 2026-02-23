using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Gopherus;

/// <summary>
/// Abstract class for Gopherus (genus).
/// NCBI TaxId: 38771
/// </summary>
public abstract class Gopherus : Testudinidae, IGopherus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gopherus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38771;

    /// <inheritdoc />
    public virtual string GenusName => "Gopherus";

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
