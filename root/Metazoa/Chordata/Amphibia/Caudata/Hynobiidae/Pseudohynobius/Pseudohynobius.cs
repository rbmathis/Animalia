using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Pseudohynobius;

/// <summary>
/// Abstract class for Pseudohynobius (genus).
/// NCBI TaxId: 157106
/// </summary>
public abstract class Pseudohynobius : Hynobiidae, IPseudohynobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudohynobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 157106;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudohynobius";

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
