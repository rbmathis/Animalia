using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Boltenia;

/// <summary>
/// Abstract class for Boltenia (genus).
/// NCBI TaxId: 63514
/// </summary>
public abstract class Boltenia : Pyuridae, IBoltenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boltenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63514;

    /// <inheritdoc />
    public virtual string GenusName => "Boltenia";

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
