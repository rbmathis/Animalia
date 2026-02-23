using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Hypocryptadius;

/// <summary>
/// Abstract class for Hypocryptadius (genus).
/// NCBI TaxId: 589840
/// </summary>
public abstract class Hypocryptadius : Zosteropidae, IHypocryptadius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypocryptadius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589840;

    /// <inheritdoc />
    public virtual string GenusName => "Hypocryptadius";

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
