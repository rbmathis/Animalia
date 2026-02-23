using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Pilherodius;

/// <summary>
/// Abstract class for Pilherodius (genus).
/// NCBI TaxId: 1118821
/// </summary>
public abstract class Pilherodius : Ardeidae, IPilherodius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pilherodius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118821;

    /// <inheritdoc />
    public virtual string GenusName => "Pilherodius";

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
