using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Cryptomicroeca;

/// <summary>
/// Abstract class for Cryptomicroeca (genus).
/// NCBI TaxId: 3150809
/// </summary>
public abstract class Cryptomicroeca : Petroicidae, ICryptomicroeca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptomicroeca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150809;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptomicroeca";

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
