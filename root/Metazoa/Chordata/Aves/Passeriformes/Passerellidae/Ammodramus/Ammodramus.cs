using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Ammodramus;

/// <summary>
/// Abstract class for Ammodramus (genus).
/// NCBI TaxId: 69261
/// </summary>
public abstract class Ammodramus : Passerellidae, IAmmodramus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammodramus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69261;

    /// <inheritdoc />
    public virtual string GenusName => "Ammodramus";

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
