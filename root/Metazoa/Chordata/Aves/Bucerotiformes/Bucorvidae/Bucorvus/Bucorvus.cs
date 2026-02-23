using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucorvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucorvidae.Bucorvus;

/// <summary>
/// Abstract class for Bucorvus (genus).
/// NCBI TaxId: 153641
/// </summary>
public abstract class Bucorvus : Bucorvidae, IBucorvus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bucorvus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 153641;

    /// <inheritdoc />
    public virtual string GenusName => "Bucorvus";

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
