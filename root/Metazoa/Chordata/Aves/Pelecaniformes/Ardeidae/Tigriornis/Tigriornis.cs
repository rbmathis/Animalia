using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Tigriornis;

/// <summary>
/// Abstract class for Tigriornis (genus).
/// NCBI TaxId: 2767384
/// </summary>
public abstract class Tigriornis : Ardeidae, ITigriornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tigriornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767384;

    /// <inheritdoc />
    public virtual string GenusName => "Tigriornis";

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
