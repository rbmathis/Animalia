using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Zalembius;

/// <summary>
/// Abstract class for Zalembius (genus).
/// NCBI TaxId: 100203
/// </summary>
public abstract class Zalembius : Embiotocidae, IZalembius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zalembius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100203;

    /// <inheritdoc />
    public virtual string GenusName => "Zalembius";

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
