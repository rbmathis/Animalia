using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Tockus;

/// <summary>
/// Abstract class for Tockus (genus).
/// NCBI TaxId: 81910
/// </summary>
public abstract class Tockus : Bucerotidae, ITockus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tockus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81910;

    /// <inheritdoc />
    public virtual string GenusName => "Tockus";

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
