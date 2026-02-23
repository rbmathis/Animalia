using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae.Mephitis;

/// <summary>
/// Abstract class for Mephitis (genus).
/// NCBI TaxId: 30546
/// </summary>
public abstract class Mephitis : Mephitidae, IMephitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mephitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30546;

    /// <inheritdoc />
    public virtual string GenusName => "Mephitis";

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
