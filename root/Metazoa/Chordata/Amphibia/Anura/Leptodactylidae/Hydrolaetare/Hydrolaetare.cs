using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Hydrolaetare;

/// <summary>
/// Abstract class for Hydrolaetare (genus).
/// NCBI TaxId: 613088
/// </summary>
public abstract class Hydrolaetare : Leptodactylidae, IHydrolaetare
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrolaetare";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613088;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrolaetare";

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
