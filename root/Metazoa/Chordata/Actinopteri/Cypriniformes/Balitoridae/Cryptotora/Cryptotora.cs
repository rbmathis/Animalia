using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Cryptotora;

/// <summary>
/// Abstract class for Cryptotora (genus).
/// NCBI TaxId: 2769382
/// </summary>
public abstract class Cryptotora : Balitoridae, ICryptotora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptotora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2769382;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptotora";

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
