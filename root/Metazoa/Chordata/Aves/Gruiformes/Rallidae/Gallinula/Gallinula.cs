using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gallinula;

/// <summary>
/// Abstract class for Gallinula (genus).
/// NCBI TaxId: 9122
/// </summary>
public abstract class Gallinula : Rallidae, IGallinula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gallinula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9122;

    /// <inheritdoc />
    public virtual string GenusName => "Gallinula";

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
